using System.ComponentModel.DataAnnotations;

namespace ExampleBlog.Models
{
    public class ArticleTagModel
    {
        [Key]
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TagId { get; set; }

}   }
