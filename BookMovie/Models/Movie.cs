using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMovie.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MovieCategory { get; set; }
        public DateTime MovieDuration { get; set; }
        public string ImageURL { get; set; }

        public Theatre Theatre { get; set; }



    }
}
