using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    public class IdentityUserBook
    {
        [Key]
        public int CollectorId { get; set; }
        [ForeignKey(nameof(CollectorId))]
        public IdentityUser Collector { get; set; } = null!;
        [Key]
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;

    }
}
