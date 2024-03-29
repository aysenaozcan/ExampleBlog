﻿using System.ComponentModel.DataAnnotations;

namespace ExampleBlog.Models
{
    public class TagModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]    
        public string Name { get; set; }
    }
}
