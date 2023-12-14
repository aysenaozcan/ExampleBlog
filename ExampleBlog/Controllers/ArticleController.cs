using ExampleBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleBlog.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            using (BlogContext dc = new BlogContext())
            {
                var articles = dc.Articles.Where(c => true).ToList();
                return View(articles)
                    //Include(i => i.Category);
            }
        }
        public IActionResult ArticleCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ArticleCreate(ArticleModel articleModel)
        {

            using (BlogContext dc = new BlogContext())
            {
                dc.Articles.Add(articleModel);
                dc.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
