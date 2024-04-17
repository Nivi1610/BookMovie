using BookMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMovie.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
            modelBuilder.Entity<Theatre>()
                .HasOne(t => t.Movie)
                .WithOne(m => m.Theatre)
                .HasForeignKey<Theatre>(t=>t.MovieId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Theatre)
                .WithMany(t => t.Schedule)
                .HasForeignKey(s => s.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Schedule)
                .WithOne(s => s.Booking)
                .HasForeignKey<Booking>(b => b.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
                  .HasOne(p => p.Booking)
                  .WithOne(b => b.Payment)
                  .HasForeignKey<Payment>(p=> p.BookingId)
                  .OnDelete(DeleteBehavior.Restrict);

              modelBuilder.Entity<Ticket>()
                  .HasOne(t=>t.Payment)
                  .WithOne(p=>p.Ticket)
                  .HasForeignKey<Ticket>(t=>t.PaymentId)
                  .OnDelete(DeleteBehavior.Restrict);

          }




    }
}
