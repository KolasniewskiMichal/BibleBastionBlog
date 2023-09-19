using BibleBastionBlog.Application.Dtos;
using BibleBastionBlog.Application.Services;
using BibleBastionBlog.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BibleBastionBlog.MCV.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto category)
        {
            await _categoryService.Create(category);
            return RedirectToAction(nameof(Create));
        }
    }
}
