using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailCommentListComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ArticleDetailCommentListComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.TGetCommentsByArticle(id);
            return View(value);
        }
    }
}
