using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Data
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Categories").HasData(
                new Category { Id = 1L, Name = "Schilderkunst" },
                new Category { Id = 2L, Name = "Fotografie" },
                new Category { Id = 3L, Name = "Grafiek" },
                new Category { Id = 4L, Name = "Beeldhouwkunst" },
                new Category { Id = 5L, Name = "ModerneMedia" },
                new Category { Id = 6L, Name = "Filmkunst" }
                );

            modelBuilder.Entity<Art>().ToTable("Arts").HasData(
               new Art { Id = 1L, ArtistId = 1L, Name = "Nachtegaal", Created = DateTime.Now, Description = "Dit is een nachtegaal", CategoryId = 1L, Price = 3759.99M, ImageName = "vogel.jpg" },
               new Art { Id = 2L, ArtistId = 1L, Name = "Vaas", Created = DateTime.Now, Description = "dat was dit een", CategoryId = 2L, Price = 6739.93M, ImageName = "vaas.jpg" },
               new Art { Id = 3L, ArtistId = 1L, Name = "Egel", Created = DateTime.Now, Description = "dit egel een was", CategoryId = 3L, Price = 6044.74M, ImageName = "egel.jpg" },
               new Art { Id = 4L, ArtistId = 1L, Name = "Trap", Created = DateTime.Now, Description = "dit is trap een", CategoryId = 4L, Price = 1236.66M, ImageName = "trap.jpg" },
               new Art { Id = 5L, ArtistId = 2L, Name = "Messen", Created = DateTime.Now, Description = "messen dit is een ", CategoryId = 5L, Price = 9765.12M, ImageName = "messen.jpg" },
               new Art { Id = 6L, ArtistId = 2L, Name = "Stenen", Created = DateTime.Now, Description = "een is stenen dit", CategoryId = 4L, Price = 2343.85M, ImageName = "stenen.jpg" },
               new Art { Id = 7L, ArtistId = 2L, Name = "Abstract", Created = DateTime.Now, Description = "abstract dit een zijn", CategoryId = 2L, Price = 9778.59M, ImageName = "abstract.jpg" },
               new Art { Id = 8L, ArtistId = 3L, Name = "Sloten", Created = DateTime.Now, Description = "is sloten een dit", CategoryId = 3L, Price = 3305.63M, ImageName = "sloten.jpg" },
               new Art { Id = 9L, ArtistId = 3L, Name = "Boor", Created = DateTime.Now, Description = "een boor dit is", CategoryId = 1L, Price = 8432.34M, ImageName = "boor.jpg" },
               new Art { Id = 10L, ArtistId = 3L, Name = "Circle", Created = DateTime.Now, Description = "circle dat geweest een", CategoryId = 2L, Price = 5943.54M, ImageName = "circle.jpg" }
           );

            modelBuilder.Entity<Artist>().ToTable("Artists").HasData(
                new { Id = 1L, ArtistName = "Pablito", Dob = DateTime.Now, UserId = "08cfe1f7-1a38-4496-a0a0-8ac3eed83cb8" },
                new { Id = 2L, ArtistName = "Jenny", Dob = DateTime.Now, UserId = "17003ca5-dbfb-4a0e-ac3b-096d96cb4a39" },
                new { Id = 3L, ArtistName = "Johnny", Dob = DateTime.Now, UserId = "3b1f2430-42e7-465f-b90c-830eea5da333" }
                );
        }
    }
}
