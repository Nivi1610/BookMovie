using System.ComponentModel.DataAnnotations;

namespace BookMovie.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MovieCategory { get; set; }
        public DateTime MovieDuration { get; set; }
        public string ImageURL { get; set; }
        public Theatre TheatreId { get; set; }
    }
}
