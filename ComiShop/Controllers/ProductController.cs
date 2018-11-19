using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiShop.Interfaces;
using ComiShop.Services;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductController(IMailService mailService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mailService = mailService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ActionResult ProductList(int id)
        {
            var product = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductListViewModel>>(_unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails).Where(p => p.CategoryId == id));
            var pager = new Pager(product.Count(), null);
            var viewModel = new PageViewModel
            {
                ProductListViewModels = product,
                Pager = pager
            };
            return View(viewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails).Where(p => p.Id == id)
                .Select(p => new Product
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    ProductDes = p.ProductDes,
                    DesDetail = p.DesDetail,
                    UnitPrice = p.UnitPrice,
                    ProductDetails = p.ProductDetails.Select(pd => new ProductDetail { ProductImage = pd.ProductImage }).ToList()
                })
                .FirstOrDefault();

            var productView = _mapper.Map<Product, ProductListViewModel>(product);
            
            var recentProduct = _unitOfWork.ProductRepository.GetAll()
                .Include(p => p.ProductDetails)
                .Where(p => p.CategoryId == product.CategoryId && p.Id != id)
                .Select(p => new Product
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    ProductDes = p.ProductDes,
                    DesDetail = p.DesDetail,
                    UnitPrice = p.UnitPrice,
                    ProductDetails = p.ProductDetails.Select(pd => new ProductDetail { ProductImage = pd.ProductImage }).ToList()
                }).ToList();

            ViewBag.RecentProducts = recentProduct;

            ViewBag.NewProduct = _unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails).OrderByDescending(p => p.CreatedDate)
                .Select(p => new Product
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    ProductDes = p.ProductDes,
                    DesDetail = p.DesDetail,
                    UnitPrice = p.UnitPrice,
                    ProductDetails = p.ProductDetails.Select(pd => new ProductDetail { ProductImage = pd.ProductImage }).ToList()
                }).Take(4).ToList();
            return View(productView);
        }
        public ActionResult Comment(int id)
        {

            return View();
        }
    }
}