using Microsoft.EntityFrameworkCore;
using MovieManagement.API.Models;

namespace MovieManagement.API.Data
{
    public class MovieDbContext :DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> option)
            : base(option)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(

                new Movie
                {
                    Id = 1,
                    Name = "Seeded Movie",
                    Cost = 300
                }
                );
        }
    }
}
