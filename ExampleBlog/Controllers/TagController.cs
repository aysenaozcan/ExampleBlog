using ExampleBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleBlog.Controllers
{
    public class TagController : Controller
    {
        public IActionResult Index()
        {
            using (BlogContext dc = new BlogContext())
            {
                var tags = dc.Tags.Where(c => true).ToList();
                return View(tags);
            }
        }
        public IActionResult TagCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TagCreate(TagModel tagModel)
        {
            using (BlogContext dc = new BlogContext())
            {
                dc.Tags.Add(tagModel);
                dc.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int tagId)
        {
            using (BlogContext dc = new BlogContext())
            {
                TagModel deletedTag = dc.Tags.First(c => c.Id == tagId);
                dc.Tags.Remove(deletedTag);
                dc.SaveChanges();

            }

            return RedirectToAction("Index", "Tag");
        }

    }
}
