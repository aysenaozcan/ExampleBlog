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

        private readonly ArticleService articleService;

        public ArticleController(ArticleService articleService)
        {
            articleService = articleService;
        }

        public IActionResult Index() => View(articleService.GetAllArticles());


        public void ArticleCreate()
        {
            articleService.CreateArticle();

        }

        [HttpPost]
        public IActionResult ArticleCreate(ArticleModel articleModel)
        {
            articleService.CreateArticle();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int articleId)
        {
            articleService.Delete(articleId);

            return RedirectToAction("Index", "Article");
        }

    }
}


