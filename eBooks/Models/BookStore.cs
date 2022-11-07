using System.ComponentModel.DataAnnotations;

namespace eBooks.Models
{
    public class BookStore
    {
        [Key]
        public int BookStoreId { get; set; }
        public string Logo { get; set; } = String.Empty;

        public string BookStoreName { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        //Relationships 

        public List<Book> Books { get; set; }
    }
}
