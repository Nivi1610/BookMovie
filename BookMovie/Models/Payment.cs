using System.ComponentModel.DataAnnotations;

namespace BookMovie.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public Register UserId { get; set; }
        [Required]
        public Booking BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
