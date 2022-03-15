using System.ComponentModel.DataAnnotations;

namespace Backend_projekt.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        [Required]
        public string? Admin_Name { get; set; }
        [Required]
        public string? Admin_Password { get; set; }

        public Admin()
        {

        }
    }
}
