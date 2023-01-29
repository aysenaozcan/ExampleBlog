using ExampleBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            List<CategoryModel> categories = new List<CategoryModel>
            {
               new CategoryModel { Id=1, Name="C#"},
               new CategoryModel { Id = 1, Name = "Html" },
               new CategoryModel { Id = 1, Name = "Css" }
            };

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
