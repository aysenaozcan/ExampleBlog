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

        private readonly ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index() => View(_articleService.GetAllArticles());


        public void ArticleCreate()
        {
            _articleService.CreateArticle();

        }

        [HttpPost]
        public IActionResult ArticleCreate(ArticleModel articleModel)
        {
            _articleService.CreateArticle();
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


