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
    [Migration("20240413101921_book")]
    partial class book
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

                    b.Property<int?>("MovieNameMovieId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfItems")
                        .HasColumnType("int");

                    b.Property<int>("NoOfSeats")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("MovieNameMovieId");

                    b.HasIndex("UserId1");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TheatreId1")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("TheatreId1");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BookMovie.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BookingId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId1");

                    b.HasIndex("UserId1");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Registers");
                });

            modelBuilder.Entity("BookMovie.Models.Theatre", b =>
                {
                    b.Property<int>("TheatreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TheatreId"));

                    b.Property<string>("TheatreAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TheatreCapacity")
                        .HasColumnType("int");

                    b.Property<string>("TheatreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheatreOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TheatreTiming")
                        .HasColumnType("datetime2");

                    b.HasKey("TheatreId");

                    b.ToTable("Theatres");
                });

            modelBuilder.Entity("BookMovie.Models.Booking", b =>
                {
                    b.HasOne("BookMovie.Models.Movie", "MovieName")
                        .WithMany()
                        .HasForeignKey("MovieNameMovieId");

                    b.HasOne("BookMovie.Models.Register", "UserId")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("MovieName");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("BookMovie.Models.Movie", b =>
                {
                    b.HasOne("BookMovie.Models.Theatre", "TheatreId")
                        .WithMany()
                        .HasForeignKey("TheatreId1");

                    b.Navigation("TheatreId");
                });

            modelBuilder.Entity("BookMovie.Models.Payment", b =>
                {
                    b.HasOne("BookMovie.Models.Booking", "BookingId")
                        .WithMany()
                        .HasForeignKey("BookingId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMovie.Models.Register", "UserId")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("BookingId");

                    b.Navigation("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
