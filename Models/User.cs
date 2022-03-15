using System.ComponentModel.DataAnnotations;

namespace Backend_projekt.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string? User_Name { get; set; }
        [Required]
        public string? User_Password { get; set; }

        public string? User_Book { get; set; }

        public User()
        {

        }
    }
}
