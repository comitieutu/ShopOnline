using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AutoMapper;
using ComiShop.Data.Entities;
using ComiShop.Interfaces;
using ComiShop.Models;
using ComiShop.Services;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
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
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductController(IMailService mailService, IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _mailService = mailService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        [Route("ProductList/{id}")]
        public IActionResult ProductList(int id, string SearchPrice = "1")
        {
            double min = 0;
            double max = 0;
            switch (SearchPrice)
            {
                case "1":
                    min = double.MinValue;
                    max = double.MaxValue;
                    break;
                case "2":
                    min = 0;
                    max = 5;
                    break;
                case "3":
                    min = 5;
                    max = 10;
                    break;
                case "4":
                    min = 10;
                    max = double.MaxValue;
                    break;
            };
            var product = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductListViewModel>>(_unitOfWork.ProductRepository.GetAll()
                .Include(p => p.ProductDetails).Where(p => p.CategoryId == id && p.Quantity > 0 && p.Deleted == false && p.UnitPrice >= min && p.UnitPrice <= max));
            var pager = new Pager(product.Count(), null);
            var viewModel = new PageViewModel
            {
                ProductListViewModels = product,
                Pager = pager
            };
            IEnumerable<SelectListItem> price = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "All"},
                new SelectListItem{ Value = "2", Text = "0 - 5"},
                new SelectListItem{ Value = "3", Text = "5 - 10"},
                new SelectListItem{ Value = "4", Text = "Trên 10"},
            };
            price.Where(p => p.Value == SearchPrice).Single().Selected = true;
            ViewBag.id = id;
            ViewBag.SearchPrice = price;
            ViewBag.Category = _unitOfWork.CategoryRepository.GetAll().Where(c => c.Deleted == false).ToList();
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
                .Where(p => p.CategoryId == product.CategoryId && p.Id != id && p.Deleted == false && p.Quantity > 0)
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

            ViewBag.RecentProducts = recentProduct;

            ViewBag.NewProduct = _unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails)
                .Where(p => p.Deleted == false && p.Quantity > 0).OrderByDescending(p => p.CreatedDate)
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
                    Context = c.Context,
                    ApplicationUser = c.ApplicationUser
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
                    ProductId = id,
                    ApplicationUser = _userManager.Users.Where(u => u.Id == _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value).Single()
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