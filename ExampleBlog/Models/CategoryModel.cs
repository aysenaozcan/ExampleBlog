using System.ComponentModel.DataAnnotations;

namespace ExampleBlog.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)] 
        public string Name { get; set; }
        public ICollection<ArticleModel> ArticleModels { get; set; }


    }
}
