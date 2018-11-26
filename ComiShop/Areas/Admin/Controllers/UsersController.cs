using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiShop.Interfaces;
using ComiShop.Models;
using ComiShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComiShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Users")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class UsersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            var userView = _mapper.Map<List<UserViewModel>>(users);
            return View(userView);
        }
        [Route("UserDetail")]
        public IActionResult UserDetail(string id)
        {
            var user = _userManager.Users.Where(u => u.Id == id).Single();
            var userView = _mapper.Map<UserViewModel>(user);
            return View(userView);
        }
        [Route("Edit")]
        [HttpGet]
        [Authorize(Roles = "SuperAdmin")]
        public IActionResult Edit(string id)
        {
            var userView = _mapper.Map<EditUserViewModel>(_userManager.Users.Where(u => u.Id == id).Single());
            return View(userView);
        }
        [Route("Edit")]
        [HttpPost]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Edit(string id, EditUserViewModel data)
        {
            var user = _userManager.Users.Where(u => u.Id == id).Single();
            if (data.Admin == true)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            return RedirectToAction("Index");
        }
    }
}