using Microsoft.EntityFrameworkCore;
using NETCoreCleanArch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreCleanArch.Infrastructure
{
    public interface IMovieDbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}
