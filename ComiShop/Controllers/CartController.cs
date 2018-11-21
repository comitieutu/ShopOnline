using AutoMapper;
using ComiShop.Helpers;
using ComiShop.Interfaces;
using ComiShop.Paypal;
using ComiShop.Services;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ComiShop.Controllers
{
    [Authorize]
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

            PayPalConfig payPalConfig = PayPalService.GetPayPalConfig();
            ViewBag.PayPalConfig = payPalConfig;

            return View();
        }
        [Route("Buy/{id}")]
        public IActionResult Buy(int id, int quantity = 1)
        {
            var product = _unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails)
                .Where(p => p.Id == id).Select(p => new Product {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    ProductDetails = p.ProductDetails.Select(pd => new ProductDetail { ProductImage = pd.ProductImage }).ToList()
                }).Single();
            if (SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<ItemViewModel>();
                cart.Add(new ItemViewModel()
                {
                    Product = product,
                    Quantity = quantity
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart");
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new ItemViewModel()
                    {
                        Product = product,
                        Quantity = quantity
                    });
                }
                else
                {
                    cart[index].Quantity += quantity;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return new EmptyResult();
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
            var receivePro = _mapper.Map<ReceiveProductViewModel, ReceiveProduct>(receiveProduct);
            receivePro.SaleId = saleId;
            _unitOfWork.ReceiveProductRepository.Create(receivePro);

            _unitOfWork.Commit();

            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", null);

            return View("Order");
        }

        [Route("Success")]
        public IActionResult Success()
        {
            var result = PDTHolder.Success(Request.Query["tx"].ToString());
            return View("Success");
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