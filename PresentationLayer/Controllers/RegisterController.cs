﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

		public async Task<IActionResult> Index(RegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.UserName,
                ImageUrl = "test"
            };
            var result=await _userManager.CreateAsync(appUser,model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
                
            }
            else 
            {
                foreach (var item in result.Errors) 
                {
                    ModelState.AddModelError("", item.Description);

                }
                return View();
            }

        }
        
    }
}
