using AutoMapper;
using ComiShop.Interfaces;
using ComiShop.Models;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ComiShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("SalesOrder")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class SalesOrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SalesOrderController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var salesOrder = _unitOfWork.SaleOrderRepository.GetAll()
                .Where(s => s.Deleted == false && (s.ShipperId == 0 || s.Payment == false || s.OrderStatus == false))
                .Select(s => new SaleOrder
                {
                    Id = s.Id,
                    UserId = s.UserId,
                    OrderStatus = s.OrderStatus,
                    TotalPrice = s.TotalPrice,
                    ShippedDate = s.ShippedDate,
                    Payment = s.Payment,
                    ShipperId = s.ShipperId,
                    ApplicationUser = _userManager.Users.Where(u => u.Id == s.UserId).Single()
                }).ToList();
            var salesOrderView = _mapper.Map<IList<SalesOrderViewModel>>(salesOrder);
            return View(salesOrderView);
        }
        [Route("ModifiedSaleOrder")]
        [HttpGet]
        public IActionResult ModifiedSaleOrder(int id)
        {
            var salesOrder = _unitOfWork.SaleOrderRepository.Get(id);
            var salesOrderView = _mapper.Map<ModifiedSaleOrderViewModel>(salesOrder);
            ViewBag.Shipper = _mapper.Map<IList<ShipperViewModel>>(_unitOfWork.ShipperRepository.GetAll().ToList());
            return View(salesOrderView);
        }
        [Route("ModifiedSaleOrder")]
        [HttpPost]
        public IActionResult ModifiedSaleOrder(ModifiedSaleOrderViewModel data)
        {
            var saleOrder = _unitOfWork.SaleOrderRepository.Get(data.Id);
            saleOrder.Payment = data.Payment;
            saleOrder.ShipperId = data.ShipperId;
            saleOrder.OrderStatus = data.OrderStatus;
            saleOrder.ShippedDate = data.ShippedDate;
            _unitOfWork.SaleOrderRepository.Edit(saleOrder);
            _unitOfWork.Commit();
            return RedirectToAction("Index");
        }
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var salesOrder = _unitOfWork.SaleOrderRepository.GetAll()
                .Where(s => s.Deleted == false)
                .Select(s => new SaleOrder
                {
                    Id = s.Id,
                    UserId = s.UserId,
                    OrderStatus = s.OrderStatus,
                    TotalPrice = s.TotalPrice,
                    ShippedDate = s.ShippedDate,
                    Payment = s.Payment,
                    ShipperId = s.ShipperId,
                    ApplicationUser = _userManager.Users.Where(u => u.Id == s.UserId).Single()
                }).ToList();
            var salesOrderView = _mapper.Map<IList<SalesOrderViewModel>>(salesOrder);
            return View(salesOrderView);
        }
        [Route("SaleOrderDetail")]
        public IActionResult SaleOrderDetail(int id)
        {
            var salesOrderDetail = _unitOfWork.SaleOrderDetailRepository.GetAll()
                .Where(s => s.SaleOrderId == id).ToList();
            var salesOrderDetailView = _mapper.Map<List<SaleOrderDetailViewModel>>(salesOrderDetail);
            return View(salesOrderDetailView);
        }
    }
}