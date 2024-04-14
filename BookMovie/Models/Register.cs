using System.ComponentModel.DataAnnotations;

namespace BookMovie.Models
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
   
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
