﻿// <auto-generated />
using System;
using BookMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookMovie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240416105839_v3")]
    partial class v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookMovie.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<int>("NoOfSeats")
                        .HasColumnType("int");

                    b.Property<double>("PricePerSeat")
                        .HasColumnType("float");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("Snacks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SnacksPrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("ScheduleId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BookMovie.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MovieDuration")
                        .HasColumnType("datetime2");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BookMovie.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BookMovie.Models.Register", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Registers");
                });

            modelBuilder.Entity("BookMovie.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduleDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScheduleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("MovieId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("BookMovie.Models.Theatre", b =>
                {
                    b.Property<int>("TheatreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TheatreId"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("TheatreAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheatreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheatreOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TheatreId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("Theatres");
                });

            modelBuilder.Entity("BookMovie.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<int>("NoOfSeatsBooked")
                        .HasColumnType("int");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<string>("TicketStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BookMovie.Models.Booking", b =>
                {
                    b.HasOne("BookMovie.Models.Schedule", "Schedule")
                        .WithOne("Booking")
                        .HasForeignKey("BookMovie.Models.Booking", "ScheduleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookMovie.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Register");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("BookMovie.Models.Payment", b =>
                {
                    b.HasOne("BookMovie.Models.Booking", "Booking")
                        .WithOne("Payment")
                        .HasForeignKey("BookMovie.Models.Payment", "BookingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookMovie.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Register");
                });

            modelBuilder.Entity("BookMovie.Models.Schedule", b =>
                {
                    b.HasOne("BookMovie.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMovie.Models.Theatre", "Theatre")
                        .WithMany("Schedule")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Theatre");
                });

            modelBuilder.Entity("BookMovie.Models.Theatre", b =>
                {
                    b.HasOne("BookMovie.Models.Movie", "Movie")
                        .WithOne("Theatre")
                        .HasForeignKey("BookMovie.Models.Theatre", "MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("BookMovie.Models.Ticket", b =>
                {
                    b.HasOne("BookMovie.Models.Payment", "Payment")
                        .WithOne("Ticket")
                        .HasForeignKey("BookMovie.Models.Ticket", "PaymentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("BookMovie.Models.Booking", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("BookMovie.Models.Movie", b =>
                {
                    b.Navigation("Theatre");
                });

            modelBuilder.Entity("BookMovie.Models.Payment", b =>
                {
                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("BookMovie.Models.Schedule", b =>
                {
                    b.Navigation("Booking");
                });

            modelBuilder.Entity("BookMovie.Models.Theatre", b =>
                {
                    b.Navigation("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
