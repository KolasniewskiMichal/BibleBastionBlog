using BibleBastionBlog.Application.Dtos;
using BibleBastionBlog.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibleBastionBlog.MCV.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public ActionResult GetAllCategories()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ArticleDto article)
        {
            await _articleService.Create(article);
            return RedirectToAction(nameof(Create));
        }
    }
}
