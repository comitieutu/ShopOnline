using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiShop.Interfaces;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHostingEnvironment _hostingEnv;

        public AdminController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnv)
        {
            _unitOfWork = unitOfWork;
            _hostingEnv = hostingEnv;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DataWarehouse()
        {
            var products = _unitOfWork.ProductRepository.GetAll().ToList();
            var productListView = Mapper.Map<List<ProductListViewModel>>(products);
            var category = _unitOfWork.CategoryRepository.GetAll().ToList();
            var warehouseView = category.Select(ct => new WarehouseView
            {
                CategoryId = ct.Id,
                CategoryName = ct.CategoryName,
                ProductList = productListView.Where(pl => pl.CategoryId == ct.Id).ToList()
            }).ToList();

            return View(warehouseView);
        }

        // GET: Admin/Create
        public ActionResult CreateProduct()
        {
            var categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            var categoryViewList = Mapper.Map<List<CategoryViewModel>>(categories);
            //var viewModel = categoryViewList.Select(x => new ProductCreateViewModel()
            //{
            //    CategoryView = new List<CategoryViewModel>
            //    {
            //        new CategoryViewModel
            //        {
            //            CategoryId = x.CategoryId,
            //            CategoryName = x.CategoryName
            //        }
            //    }
            //}).Single();

            var viewModel = new ProductCreateViewModel()
            {
                CategoryView = categoryViewList
            };
            ViewData["Category"] = categoryViewList;
            return View(viewModel);
        }

        // POST: Admin/Create   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(ProductCreateViewModel productCreate, List<IFormFile> files = null)
        {
                try
                {
                    var product = Mapper.Map<Product>(productCreate);
                    _unitOfWork.ProductRepository.Create(product);
                    _unitOfWork.Commit();
                    
                    var productId = _unitOfWork.ProductRepository.GetByUId(product.UniqueId).Id;

                    var filePath = _hostingEnv.WebRootPath + "\\images";
                    foreach (var formFile in files)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(formFile.FileName);
                        if (formFile.Length > 0)
                        {
                            using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                            {
                                await formFile.CopyToAsync(stream);
                            }
                        }
                        _unitOfWork.ProductDetailRepository.Create(new ProductDetail{ ProductId = productId, ProductImage = fileName});
                    }
                    _unitOfWork.Commit();
                    
                    return RedirectToAction("CreateProduct");
                }
                catch (Exception e)
                {
                    return View("Index");
                }
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(CategoryCreateViewModel category)
        {
            _unitOfWork.CategoryRepository.Create(Mapper.Map<Category>(category));   
            _unitOfWork.Commit();
            return View();
        }

        [HttpGet]
        public ActionResult CategoryList()
        {
            var categories = _unitOfWork.CategoryRepository.GetAll().Include(x => x.Products).ToList();
            var categoriesView = Mapper.Map<List<CategoryViewModel>>(categories);
            return View(categoriesView);
        }

        // GET: Admin/Edit/5
        public ActionResult CategoryDetail(int id)
        {
            var category = _unitOfWork.CategoryRepository.Get(id);
            var categoryView = Mapper.Map<CategoryViewModel>(category);
            return View(categoryView);
        }

        public ActionResult EditCategory(CategoryViewModel categoryView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var categoryUpdate = Mapper.Map<Category>(categoryView);
                    _unitOfWork.CategoryRepository.Edit(categoryUpdate);
                    _unitOfWork.Commit();
                    return Redirect("CategoryList");
                }
                catch (Exception e)
                {
                    throw new Exception(nameof(e));
                }
            }
            else
            {
                return BadRequest(ModelState);
            }            
        }

        public ActionResult DeleteCategory(int id)
        {
            try
            {
                _unitOfWork.CategoryRepository.Delete(id);
                _unitOfWork.Commit();
                return RedirectToAction("CategoryList");
            }
            catch (Exception e)
            {
                throw new Exception(nameof(e));
            }
        }


    }
}
