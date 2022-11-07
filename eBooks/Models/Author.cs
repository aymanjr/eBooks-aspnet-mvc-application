using System.ComponentModel.DataAnnotations;

namespace eBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string ProfilePictureURL { get; set; } = String.Empty;

        public string FullName { get; set; } = String.Empty;

        public string Bio { get; set; } = String.Empty;

        //Relationships

        public List<Author_Book> Author_Books { get; set; }

    }
}
