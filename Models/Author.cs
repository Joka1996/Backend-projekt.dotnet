using System.ComponentModel.DataAnnotations;

namespace Backend_projekt.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string? Author_Name { get; set; }

        public string? Author_books { get; set; } = null;

        public Author()
        {

        }
    }
}
