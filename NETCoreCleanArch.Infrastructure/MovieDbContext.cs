using Microsoft.EntityFrameworkCore;
using NETCoreCleanArch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreCleanArch.Infrastructure
{
    public class MovieDbContext : DbContext, IMovieDbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many Member and Rentals
            modelBuilder.Entity<Member>()
                .HasOne<Rental>(r => r.Rental)
                .WithMany(m => m.Members)
                .HasForeignKey(f => f.RentalId);

            //Many to Many
            modelBuilder.Entity<MovieRental>()
                .HasKey(g => new { g.RentalId, g.MovieId });

            // Handle Decimals to avoid precision loss
            modelBuilder.Entity<Rental>()
                .Property(p => p.TotalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Movie>()
                .Property(p => p.RentalCost)
                .HasColumnType("decimal(18,2)");

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}