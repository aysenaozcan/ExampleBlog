using System.ComponentModel.DataAnnotations;

namespace ExampleBlog.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; } 
        public ICollection<ArticleModel> ArticleModels { get; set; } //Makalelerin çoklu gelebilmesi için ICollection kullandık.  
    }
}
