﻿using ExampleBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            using (BlogContext dc = new BlogContext()) 
            {
                var categories = dc.Categories.Where(c => true).ToList();
                return View(categories);
            }

               
        }

        //HttpGet
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel categoryModel)
        {
            //otomatik olarak dispose olması için using kullanılır
            using (BlogContext dc = new BlogContext()) 
            {
                dc.Categories.Add(categoryModel);
                dc.SaveChanges();
            }

            return RedirectToAction("Index");   
        }

        [HttpPost]
        public IActionResult Delete(int categoryId)
        {
            using (BlogContext dc = new BlogContext())
            {
                CategoryModel deletedCategory = dc.Categories.First(c => c.Id == categoryId);
                dc.Categories.Remove(deletedCategory);
                dc.SaveChanges();

            }

            return RedirectToAction("Index", "Category");
        }
    }
}
