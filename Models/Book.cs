//använda sig av required
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_projekt.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string? Book_Title { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public string? Category { get; set; }
        [Required]
        [Range(1, 2000)]
        public int? Book_Pages { get; set; }
        [Range(1, 5)]
        public int? Book_Rating { get; set; }
        [Required]
        public string? Book_ImageUrl { get; set; }

        public bool Book_Rented { get; set; } = false;

        public DateTime? Book_TimeRented { get; set; } = null;

        public string? User { get; set; }

        public Book()
        {

        }
    }
}
