using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AutoMapper;
using ComiShop.Data.Entities;
using ComiShop.Interfaces;
using ComiShop.Services;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiShop.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductController(IMailService mailService, IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _mailService = mailService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        [Route("ProductList/{id}")]
        public ActionResult ProductList(int id)
        {
            var product = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductListViewModel>>(_unitOfWork.ProductRepository.GetAll()
                .Include(p => p.ProductDetails).Where(p => p.CategoryId == id && p.Deleted == false));
            var pager = new Pager(product.Count(), null);
            var viewModel = new PageViewModel
            {
                ProductListViewModels = product,
                Pager = pager
            };
            return View(viewModel);
        }

        [Route("Details/{id}")]
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
                }).FirstOrDefault();

            var productView = _mapper.Map<Product, ProductListViewModel>(product);
            
            var recentProduct = _unitOfWork.ProductRepository.GetAll()
                .Include(p => p.ProductDetails)
                .Where(p => p.CategoryId == product.CategoryId && p.Id != id && p.Deleted == false)
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

            ViewBag.NewProduct = _unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails)
                .Where(p => p.Deleted == false).OrderByDescending(p => p.CreatedDate)
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

            var comment = _unitOfWork.CommentRepository.GetAll().Include(c => c.ApplicationUser)
                .Where(c => c.ProductId == id && c.Deleted == false)
                .Select(c => new Comment
                {
                    UserId = c.UserId,
                    ProductId = c.ProductId,
                    Context = c.Context
                }).ToList();
            var commentView = _mapper.Map<List<CommentViewModel>>(comment);

            var detailView = new ProductDetailViewModel {
                ProductListViewModel = productView,
                CommentViewModels = commentView,
                CommentCreateViewModel = new CommentCreateViewModel() };
            return View(detailView);
        }
        [Route("Comment")]
        public ActionResult Comment(int id, ProductDetailViewModel data)
        {
            if (_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
            {
                var cmt = new Comment
                {
                    Context = data.CommentCreateViewModel.Context,
                    UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    ProductId = id
                };
                _unitOfWork.CommentRepository.Create(cmt);
                _unitOfWork.Commit();
            }
            else
            {
                return Redirect("/Identity/Account/Login");
            }
            return RedirectToAction("Details", new { id });
        }
    }
}