using eBooks.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eBooks.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public string Isbn13 { get; set; }

        public string language { get; set; }

        public DateTime PublicationDate { get; set; }

        public BookCategory BookCategory { get; set; }

        public int NumPages { get; set; }

        public string ImgURL { get; set; }
        public double Price { get; set; }


        //Relationships 

        public List<Author_Book> Author_Books { get; set; }

        //bookstore
        public int BookStoreId { get; set; }
        [ForeignKey("BookStoreId")]
        public BookStore BookStore { get; set; }

        //Publisher
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
    }
}
