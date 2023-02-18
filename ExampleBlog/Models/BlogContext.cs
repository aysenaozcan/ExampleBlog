using Microsoft.EntityFrameworkCore;

namespace ExampleBlog.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ArticleModel> Articles { get; set; }
        public DbSet<ArticleTagModel> ArticleTags { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TagModel> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-LMRC99NP; database=ExampleBlog; integrated security=true; Encrypt=False");
        }

    }


}
