using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class AddBookViewModel
    {
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
        public string Category { get; set; } = null!;
    }
}
