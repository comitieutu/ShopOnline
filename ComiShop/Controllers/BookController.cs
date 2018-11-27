using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiShop.Interfaces;
using ComiShop.Services;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiShop.Controllers
{
    [Route("Book")]
    public class BookController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public BookController(IMailService mailService, IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailService)
        {
            _mailService = mailService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _emailService = emailService;
        }

        [Route("")]
        [Route("Index")]
        [Route("~/")]
        public async Task<IActionResult> Index()
        {
            ViewBag.NewProduct = _unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails)
                .Where(p => p.Deleted == false && p.Quantity > 0).OrderByDescending(p => p.CreatedDate).Take(4).ToList();

            var so = _unitOfWork.SaleOrderDetailRepository.GetAll().GroupBy(s => s.ProductId)
                .Select(o => new { ProductId = o.FirstOrDefault().ProductId, Quantity = o.Sum(p => p.Quantity) })
                .OrderByDescending(p => p.Quantity).Take(4).ToList();

            List<Product> bestSellers = new List<Product>();
            so.ForEach(s => bestSellers.Add(_unitOfWork.ProductRepository.GetAll()
                .Include(p => p.ProductDetails)
                .Where(p => p.Id == s.ProductId && p.Deleted == false).Single()));
            ViewBag.BestSellers = bestSellers;
            return View();
        }
        [Route("Contact")]
        [HttpGet("contact")]
        public ActionResult Contact()
        {
            return View();
        }
        [Route("Contact")]
        [HttpPost("contact")]
        public async Task<IActionResult> Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _emailService.SendEmail(model.Email, $"{model.Name} - {model.Phone}", model.Mesage);               
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            return View();
        }
    }
}