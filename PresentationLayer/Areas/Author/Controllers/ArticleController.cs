using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly UserManager<AppUser> _userManager;

        public ArticleController(IArticleService articleService, UserManager<AppUser> userManager)
        {
            _articleService = articleService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyArticleList()
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            var articleList = _articleService.TGetArticlesByAppUserId(userValue.Id);
            return View(articleList);
        }
    }
}
