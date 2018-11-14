using AutoMapper;
using ComiShop.Helpers;
using ComiShop.Interfaces;
using ComiShop.Services;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ComiShop.Controllers
{
    [Route("Cart")]
    public class CartController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartController(IMailService mailService, IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _mailService = mailService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(i => i.Product.UnitPrice * i.Quantity);
            }

            return View();
        }
        [Route("Buy/{id}")]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<ItemViewModel>();
                cart.Add(new ItemViewModel() { Product = _unitOfWork.ProductRepository.Get(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart");
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new ItemViewModel() { Product = _unitOfWork.ProductRepository.Get(id), Quantity = 1 });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return new EmptyResult();
            //return RedirectToAction("Index");
        }

        [Route("Remove/{id}")]
        public IActionResult Remove(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            if(cart.Count == 0)
            {
                cart = null;
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        [Route("Order")]
        [HttpPost]
        public IActionResult Order(ReceiveProductViewModel receiveProduct)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var cart = SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart");
            var order = new SaleOrder
            {
                TotalPrice = cart.Sum(i => i.Product.UnitPrice * i.Quantity),
                UserId = userId,
                ShipperId = 1
            };
            
            _unitOfWork.SaleOrderRepository.Create(order);
            _unitOfWork.Commit();

            var saleId = _unitOfWork.SaleOrderRepository.GetByUId(order.UniqueId).Id;

            cart.ForEach(i => _unitOfWork.SaleOrderDetailRepository.Create(new SaleOrderDetail
            {
                SaleOrderId = saleId,
                ProductId = i.Product.Id,
                Quantity = i.Quantity,
                UnitPrice = i.Product.UnitPrice
            }));

            cart.ForEach(i => 
            {
                i.Product.Quantity -= i.Quantity;
                _unitOfWork.ProductRepository.Edit(i.Product);
            });
            var receivePro = Mapper.Map<ReceiveProductViewModel, ReceiveProduct>(receiveProduct);
            receivePro.SaleId = saleId;
            _unitOfWork.ReceiveProductRepository.Create(receivePro);

            _unitOfWork.Commit();

            return RedirectToAction("Index", "Book");
        }

        private int Exists(List<ItemViewModel> cart, int id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}