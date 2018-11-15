using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiShop.Interfaces;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComiShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            });

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
        public async Task<IActionResult> CreateProduct(ProductCreateViewModel productCreate, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var product = Mapper.Map<Product>(productCreate);
                    _unitOfWork.ProductRepository.Create(product);
                    
                    var productId = _unitOfWork.ProductRepository.GetByUId(product.UniqueId).Id;
                    
                    var filePath = Path.GetTempFileName();
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
            return View("Index");
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            _unitOfWork.CategoryRepository.Create(category);            
            return View();
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
