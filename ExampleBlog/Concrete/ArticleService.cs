using ExampleBlog.Models;
using ExampleBlog.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace ExampleBlog.Concrete
{
    public class ArticleService : IArticleService
    {

        public ArticleService() { }


        public void CreateArticle(ArticleModel articleModel)
        {

            using (BlogContext dc = new BlogContext())
            {
                //ViewBag.Users = new SelectList(dc.Users.Select(user => new String(user.Name)).ToList());
                //ViewBag.Categories = new SelectList(dc.Categories.Select(category => new String(category.Name)).ToList());
                dc.Articles.Add(articleModel);
                dc.SaveChanges();

            }

        }

        public List<ArticleModel> GetAllArticles()
        {
            return GetArticlesFromDb();
        }
        private List<ArticleModel> GetArticlesFromDb()
        {
            using (BlogContext dc = new BlogContext())
            {
                return dc.Articles.Where(c => true).Include(a => a.UserModel).Include(a => a.CategoryModel).ToList();
            }
        }
        public void Delete(int articleId)
        {
            using (BlogContext dc = new BlogContext())
            {
                ArticleModel deletedArticle = dc.Articles.First(c => c.Id == articleId);
                dc.Articles.Remove(deletedArticle);
                dc.SaveChanges();

            }
        }

      

       
    }

}
