﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(10), MaxLength(50)]
        public string Title { get; set; } = null!;
        [Required]
        [MinLength(5), MaxLength(50)]
        public string Author { get; set; } = null!;
        [Required]
        [MinLength(5), MaxLength(5000)]
        public string Description { get; set; } = null!;
        [Required]
        public string ImageUrl { get; set; } = null!;
        [Required]
        [Range(0.0, 10.0)]
        public decimal Rating { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
        public List<IdentityUserBook> UsersBooks { get; set; } = new List<IdentityUserBook>();
    }
}
