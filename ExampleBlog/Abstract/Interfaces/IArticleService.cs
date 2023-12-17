using ExampleBlog.Concrete;
using ExampleBlog.Models;

namespace ExampleBlog.Services.Interfaces
{
    /// <summary>
    /// Interface for article related logic.
    /// </summary>
    public interface IArticleService 
    {
        /// <summary>
        /// Method that returns all of the articles from dataset.
        /// </summary>
        /// <returns>All of the articles as list.</returns>
        List<ArticleModel> GetAllArticles();
        void CreateArticle();
        public void Delete(int articleId);
    }
}
