using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Areas.Author.Models;

namespace PresentationLayer.Areas.Author.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Surname = user.Surname;
            model.UserName = user.UserName;
            model.Email = user.Email;
            model.Name = user.Name;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Surname=model.Surname;
            user.Name=model.Name;
            user.Email=model.Email;
            user.UserName=model.UserName;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");

            }
            else 
            {
                return View();
            }
            

        }
    }
}
