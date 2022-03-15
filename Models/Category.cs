using System.ComponentModel.DataAnnotations;
namespace Backend_projekt.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string? Category_Name { get; set; }

        public Category()
        {

        }
    }
}
