using ExampleBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleBlog.Controllers
{
    public class TagController : Controller
    {
        public IActionResult Index()
        {
            List<TagModel> tags = new List<TagModel>
            {
               new TagModel { Id=1, Name="C# ile geliştirme"},
               new TagModel { Id=2, Name="Htmlde önemli şeyler"},
               new TagModel { Id=3, Name="Css nedir?"}
              
            };
            return View(tags);
        }
        public IActionResult TagCreate()
        {
            return View();
        }

    }
}
