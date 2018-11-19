using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiShop.Data;
using ComiShop.Implementations;
using ComiShop.Interfaces;
using ComiShop.Services;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiShop.Controllers
{
    public class BookController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookController(IMailService mailService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mailService = mailService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: Book   
        public ActionResult Index()
        {
            ViewBag.NewProduct = _unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails).OrderByDescending(p => p.CreatedDate).Take(4).ToList();
            var so = _unitOfWork.SaleOrderDetailRepository.GetAll().GroupBy(s => s.ProductId)
                .Select(o => new { ProductId = o.FirstOrDefault().ProductId, Quantity = o.Sum(p => p.Quantity) }).OrderByDescending(p => p.Quantity).Take(4).ToList();
            List<Product> bestSellers = new List<Product>();
            so.ForEach(s => bestSellers.Add(_unitOfWork.ProductRepository.GetAll().Include(p => p.ProductDetails).Where(p => p.Id == s.ProductId).Single()));
            ViewBag.BestSellers = bestSellers;
            return View();
        }

        [HttpGet("contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public ActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("lecomineko@gmail.com", model.Name, $"From : {model.Email}, Message: {model.Mesage}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
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

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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