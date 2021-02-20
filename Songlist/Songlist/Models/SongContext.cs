using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songlist.Models
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "M", Name = "Metal" },
               new Genre { GenreId = "R", Name = "Rap" },
               new Genre { GenreId = "H", Name = "Hip Hop" },
              new Genre { GenreId = "RC", Name = "Rock" });
            modelBuilder.Entity<Song>().HasData(

                new Song
                {
                    SongId = 1,
                    Name = "Master of Puppets",
                    Year = 1980,
                    Rating = 5,
                    GenreId="M"
                },
                new Song
                {
                    SongId = 2,
                    Name = "Wonderwall",
                    Rating = 4,
                    Year = 1990,
                    GenreId="RC"
                },
                 new Song
                 {
                     SongId = 3,
                     Name = "Lose Yourself",
                     Rating = 1,
                     Year = 2005,
                     GenreId="R"
                 }
                );
        }
    }
}
