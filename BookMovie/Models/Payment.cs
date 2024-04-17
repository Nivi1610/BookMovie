using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMovie.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }


        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Register Register { get; set; }

      
        public int BookingId { get; set; }
        [ForeignKey("BookingId")]
        public virtual Booking Booking {  get; set; } 
        
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentStatus { get; set; }

        public virtual Ticket Ticket { get; set; }
        

    }
}
