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

        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAll();
            return View(articles);
        }

        [HttpGet]
        public IActionResult Create()
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
