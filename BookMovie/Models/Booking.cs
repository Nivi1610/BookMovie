using System.ComponentModel.DataAnnotations;

namespace BookMovie.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public Register UserId { get; set; }
        public Movie MovieName { get; set; }
        public int NoOfSeats { get; set; }
        public int NoOfItems { get; set; }
    }
}
