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
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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
        private static readonly HttpClient _client = new HttpClient();

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

        [Route("Success")]
        public IActionResult Success()
        {
            var result = PDTHolder.Success(Request.Query["tx"].ToString());
            if (result != null)
            {
                return RedirectToAction("CheckOut", new { id = "paypal" });
            }
            return RedirectToAction("False");
        }

        [Route("False")]
        [HttpGet]
        public IActionResult False()
        {
            return View();
        }

        [Route("Complete")]
        [HttpGet]
        public IActionResult Complete()
        {
            return View();
        }

        [Route("CheckOut/{id}")]
        [HttpGet]
        public IActionResult CheckOut(string id)
        {
            ViewBag.method = id == "cash" ? "cash" : "paypal";
            return View();
        }
        [Route("CheckOut/{id}")]
        [HttpPost]
        public IActionResult CheckOut(string id, ReceiveProductViewModel receiveProduct)
        {
            if (id == "CheckOutCash")
            {
                SaleOrder(receiveProduct, false);
            }
            else
            {
                SaleOrder(receiveProduct, true);
            }
            return RedirectToAction("Complete");
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

        private void SaleOrder(ReceiveProductViewModel receiveProduct, bool payment)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var cart = SessionHelper.GetObjectFromJson<List<ItemViewModel>>(HttpContext.Session, "cart");

            var order = new SaleOrder
            {
                TotalPrice = cart.Sum(i => i.Product.UnitPrice * i.Quantity),
                UserId = userId,    
                Payment = payment
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

            Product product = new Product();
            cart.ForEach(i =>
            {
                product = _unitOfWork.ProductRepository.Get(i.Product.Id);
                product.Quantity -= i.Quantity;
                _unitOfWork.ProductRepository.Edit(product);
            });
            var receivePro = _mapper.Map<ReceiveProductViewModel, ReceiveProduct>(receiveProduct);
            receivePro.SaleId = saleId;
            _unitOfWork.ReceiveProductRepository.Create(receivePro);

            _unitOfWork.Commit();

            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", null);
        }
    }
}