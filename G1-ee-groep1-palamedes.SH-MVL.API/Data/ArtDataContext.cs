
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Data
{
    public class ArtDataContext : DbContext
    {
        public ArtDataContext(DbContextOptions<ArtDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Art>().ToTable("Arts").HasData(
                new Art { Id = 1, ArtistId = 1, Name = "Nachtegaal", Created = DateTime.Now, Description = "Een schilderij van een vogel.", Price = 300, CategoryId = 1, ImageName = "vogel.jpg" },
                new Art { Id = 2, ArtistId = 1, Name = "Vaas", Created = DateTime.Now, Description = "Een schilderij van een Vaas.", Price = 1, CategoryId = 2, ImageName = "vaas.jpg" },
                new Art { Id = 3, ArtistId = 1, Name = "Egel", Created = DateTime.Now, Description = "Een schilderij van een Egel.", Price = 5, CategoryId = 2, ImageName = "egel.jpg" },
                new Art { Id = 4, ArtistId = 1, Name = "Trap", Created = DateTime.Now, Description = "Een schilderij van een trap.", Price = 150, CategoryId = 2, ImageName = "trap.jpg" },
                new Art { Id = 5, ArtistId = 2, Name = "Messen", Created = DateTime.Now, Description = "messen", CategoryId = 0, Price = 500, ImageName = "messen.jpg" },
                new Art { Id = 6, ArtistId = 2, Name = "Stenen", Created = DateTime.Now, Description = "steinen", CategoryId = 0, Price = 500, ImageName = "stenen.jpg" },
                new Art { Id = 7, ArtistId = 2, Name = "Abstract", Created = DateTime.Now, Description = "steinen", CategoryId = 0, Price = 500, ImageName = "abstract.jpg" },
                new Art { Id = 8, ArtistId = 2, Name = "Sloten", Created = DateTime.Now, Description = "steinen", CategoryId = 0, Price = 500, ImageName = "sloten.jpg" },
                new Art { Id = 9, ArtistId = 2, Name = "Boor", Created = DateTime.Now, Description = "steinen", CategoryId = 0, Price = 500, ImageName = "boor.jpg" },
                new Art { Id = 10, ArtistId = 2, Name = "Circle", Created = DateTime.Now, Description = "steinen", CategoryId = 0, Price = 500, ImageName = "circle.jpg" }
            );

            modelBuilder.Entity<Artists>().ToTable("Artists").HasData(
                new Artists { Id = 1, ArtistName = "Pablito", Dob = DateTime.Now, UserId = 6 },
                new Artists { Id = 2, ArtistName = "Jenny", Dob = DateTime.Now, UserId = 5 }
            );

            modelBuilder.Entity<User>().ToTable("Users").HasData(
                new User { Id = 1, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "jos", LastName = "doenikni", TelNr = 48484848},
                new User { Id = 2, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "carlos", LastName = "taco", TelNr = 48484848},
                new User { Id = 3, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "donald", LastName = "cunk", TelNr = 48484848},
                new User { Id = 4, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "Leoplod", LastName = "II", TelNr = 48484848 },
                new User { Id = 5, Dob = new DateTime(1960, 5, 30), Email = "manu09ice@gmail.com", FirstName = "Jenny", LastName = "VanGimst", TelNr = 491080115 },
                new User { Id = 6, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "Pablito", LastName = "escobar", TelNr = 48484848 }
                );


            modelBuilder.Entity<Art>().Property("Price").HasColumnType("decimal(18,2)");


        }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Art> Arts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
