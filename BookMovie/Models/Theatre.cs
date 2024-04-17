using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int NoOfSeats { get; set; }

        public ICollection<Schedule> Schedule { get; set; }

        [ForeignKey("Movie")]
        public int MovieId {  get; set; }
        public Movie Movie { get; set; }


    }
}
