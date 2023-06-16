using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(5), MaxLength(50)]
        public string Name { get; set; } = null!;
        public List<Book> Books { get; set; } = null!;
    }
}
