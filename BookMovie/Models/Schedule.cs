using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMovie.Models
{
    public class Schedule
    {
       
        [Key]
        public int ScheduleId { get; set; }
        public string ScheduleName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int AvailableSeats { get; set; }

       
        public int TheatreId { get; set; }
        [ForeignKey("TheatreId")]
        public virtual Theatre Theatre { get; set; }

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }

        public DateTime ScheduleDate{ get; set; }
        public virtual Booking Booking { get; set; }
        




    }
}
