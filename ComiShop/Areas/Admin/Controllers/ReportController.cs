using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiShop.Interfaces;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var warehouseReport = WarehouseReport();
            return View(warehouseReport);
        }

        private List<CategoryWarehouse> WarehouseReport()
        {
            var productList = _unitOfWork.ProductRepository.GetAll().Include(x => x.Category)
                .Where(x => x.Deleted == false).Select(x => new Product {
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice,
                    Category = new Category
                    {
                        Id = x.Category.Id,
                        CategoryName = x.Category.CategoryName
                    }
                })
                .GroupBy(x => x.CategoryId).ToList();

            List<CategoryWarehouse> categoryWarehouses = new List<CategoryWarehouse>();

            foreach(var product in productList)
            {
                CategoryWarehouse categoryWarehouse = new CategoryWarehouse
                {
                    CategoryName = product.First().Category.CategoryName,
                    TotalQuantity = product.Sum(x => x.Quantity),
                };

                categoryWarehouses.Add(categoryWarehouse);
            }

            return categoryWarehouses;
        }
    }
}