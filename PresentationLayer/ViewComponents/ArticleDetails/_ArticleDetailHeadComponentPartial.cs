using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
