using System.ComponentModel.DataAnnotations;

namespace eBooks.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public string ProfilePictureURL { get; set; } = String.Empty;

        public string FullName { get; set; } = String.Empty;

        public string Bio { get; set; } = String.Empty;

        //relationships

        public List<Book> Books { get; set; } 
    }
}
