using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMovie.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        public int NoOfSeatsBooked { get; set; }
        public string TicketStatus { get; set;  }

       
        public int PaymentId { get; set; }
        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }
    }
}
