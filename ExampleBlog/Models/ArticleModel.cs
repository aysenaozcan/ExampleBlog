using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleBlog.Models
{
    public class ArticleModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
        [ForeignKey("UserModel")] //Article tablosundaki UserId nin foreign Keyi 
        public int UserId { get; set; }
        [ForeignKey("CategoryModel")]
        public int CategoryId { get; set; }
        public UserModel UserModel { get; set; } //UserModel oluşturduk. Foreign key oluşturabilmek için.
        public CategoryModel CategoryModel { get; set; }
    }
}
