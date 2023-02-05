using System.ComponentModel.DataAnnotations;

namespace ExampleBlog.Models
{
    public class ArticleTag
    {
        [Key]
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TagId { get; set; }

}   }
