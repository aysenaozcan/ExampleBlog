using ExampleBlog.Concrete;
using ExampleBlog.Models;
using ExampleBlog.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ExampleBlog.Controllers
{
    public class ArticleController : Controller 
    {

        private readonly  IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index()
        {

            return View(_articleService.GetAllArticles());
        }


        [HttpGet]
        public IActionResult ArticleCreate()
        {
            return View();

        }

        [HttpPost]
        public IActionResult ArticleCreate(ArticleModel articleModel)
        {
            _articleService.CreateArticle(articleModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int articleId)
        {
            _articleService.Delete(articleId);

            return RedirectToAction("Index", "Article");
        }

    }
}


