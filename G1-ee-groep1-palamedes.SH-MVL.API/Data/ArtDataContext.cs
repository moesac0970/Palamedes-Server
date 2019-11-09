using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Data
{
    public class ArtDataContext<TUser> : IdentityDbContext<TUser, IdentityRole, string>
                                                             where TUser : IdentityUser
    {
        public ArtDataContext(DbContextOptions<ArtDataContext<TUser>> options)
            : base(options)
        {
        }

        public DbSet<Art> Arts { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

            modelBuilder.Entity<Artist>().ToTable("Artists").HasData(
                new { Id = 1, ArtistName = "Pablito", Dob = DateTime.Now, UserId = "1" },
                new { Id = 2, ArtistName = "Jenny", Dob = DateTime.Now, UserId = "2" }
            );
            // paswords for users unhashed (md5 hashed) @sepp
            // 1 = 1234Pasw
            // 2 = GeneralReaper666
            modelBuilder.Entity<IdentityUser>().ToTable("Users").HasData(
                new IdentityUser { Id = "1", Email="de__manu09@hotmail.com", PasswordHash= "675d13fc79dc2b90de05b11b36ec388a", UserName = "manu", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = true, LockoutEnabled = false, AccessFailedCount = 1 },
                new IdentityUser { Id = "2", UserName = "VanGimst", PasswordHash= "754f4789adeac685009905e3a5b9c6ef", Email ="random@mailinator.com", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = true, LockoutEnabled = false, AccessFailedCount = 1 });


            modelBuilder.Entity<Art>().Property("Price").HasColumnType("decimal(18,2)");
            
        }
    }
}
