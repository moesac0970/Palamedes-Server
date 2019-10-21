
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
            modelBuilder.Entity<Art>()
                .ToTable("Arts")
                .HasData(
                new Art { Id = 1, Artist = "pablito", Name = "De Nachtegaal", Created = DateTime.Now, Description = "Een schilderij van een vogel.", Price = 300, Category = "barock", ImageName = "devogel.jpg" },
                new Art { Id = 2, Artist = "pablito", Name = "De Vaas", Created = DateTime.Now, Description = "Een schilderij van een Vaas.", Price = 1, Category = "gothiek", ImageName = "devaas.jpg" },
                new Art { Id = 3, Artist = "pablito", Name = "De Egel", Created = DateTime.Now, Description = "Een schilderij van een Egel.", Price = 5, Category = "abstracte kunst", ImageName = "deegel.jpg" },
                new Art { Id = 4, Artist = "pablito", Name = "De Trap", Created = DateTime.Now, Description = "Een schilderij van een trap.", Price = 150, Category = "Moderne Kunst", ImageName = "trap.jpg" }
                );

            modelBuilder.Entity<Art>()
                 .Property("Price")
                 .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasData(
                new { Id = 1, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "jos", LastName = "doenikni", TelNr = 48484848, AdressId = 1 },
                new { Id = 2, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "carlos", LastName = "taco", TelNr = 48484848, AdressId = 3 },
                new { Id = 3, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "donald", LastName = "cunk", TelNr = 48484848, AdressId = 4 },
                new { Id = 4, Dob = new DateTime(1980, 5, 20), Email = "random@mailinator.com", FirstName = "Leoplod", LastName = "II", TelNr = 48484848, AdressId = 2 });

        }

        public DbSet<Art> Arts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
