namespace Library.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Rating { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<IdentityUserBook> UsersBooks { get; set; } = new List<IdentityUserBook>();
    }
}
