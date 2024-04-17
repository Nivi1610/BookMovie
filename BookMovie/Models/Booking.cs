using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMovie.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Register Register { get; set; }
        public int ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public virtual Schedule Schedule { get; set; }
        public int NoOfSeats { get; set; }
        public double PricePerSeat { get; set; }
        public string Snacks { get; set; }
        public double SnacksPrice { get; set; }
        public double TotalAmount { get; set; }
      
        public virtual Payment Payment { get; set; }

       
    }
}
