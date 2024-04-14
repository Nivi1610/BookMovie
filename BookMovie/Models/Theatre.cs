using System.ComponentModel.DataAnnotations;

namespace BookMovie.Models
{
    public class Theatre
    {
        [Key]
        public int TheatreId { get; set; }
        [Required]
        public string TheatreName { get; set; }
        [Required]
        public string TheatreAddress { get; set; }
        [Required]
        public string TheatreOwnerName { get; set; }
        
        [Required]
        public int TheatreCapacity { get; set; }
        [Required]
        public DateTime TheatreTiming { get; set; }
    }
}
