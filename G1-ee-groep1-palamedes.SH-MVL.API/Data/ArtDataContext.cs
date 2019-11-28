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
        public DbSet<BearerHistory> BearerHistories { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Seed Data
            modelBuilder.Entity<Category>().ToTable("Categories").HasData(
                new Category { Id = 0, Name = "Schilderkunst" },
                new Category { Id = 1, Name = "Fotografie" },
                new Category { Id = 2, Name = "Grafiek" },
                new Category { Id = 3, Name = "Beeldhouwkunst" },
                new Category { Id = 4, Name = "ModerneMedia" },
                new Category { Id = 5, Name = "Filmkunst" }
                );

            modelBuilder.Entity<Art>().ToTable("Arts").HasData(
               new Art { Id = 0, ArtistId = 0, Name = "Nachtegaal", Created = DateTime.Now, Description = "Dit is een nachtegaal", CategoryId = 0, Price = 3759.99M, ImageName = "vogel.jpg" },
               new Art { Id = 1, ArtistId = 0, Name = "Vaas", Created = DateTime.Now, Description = "dat was dit een", CategoryId = 1, Price = 6739.93M, ImageName = "vaas.jpg" },
               new Art { Id = 2, ArtistId = 0, Name = "Egel", Created = DateTime.Now, Description = "dit egel een was", CategoryId = 2, Price = 6044.74M,  ImageName = "egel.jpg" },
               new Art { Id = 3, ArtistId = 0, Name = "Trap", Created = DateTime.Now, Description = "dit is trap een", CategoryId = 3, Price = 1236.66M, ImageName = "trap.jpg" },
               new Art { Id = 4, ArtistId = 1, Name = "Messen", Created = DateTime.Now, Description = "messen dit is een ", CategoryId = 4, Price = 9765.12M, ImageName = "messen.jpg" },
               new Art { Id = 5, ArtistId = 1, Name = "Stenen", Created = DateTime.Now, Description = "een is stenen dit", CategoryId = 5, Price = 2343.85M, ImageName = "stenen.jpg" },
               new Art { Id = 6, ArtistId = 1, Name = "Abstract", Created = DateTime.Now, Description = "abstract dit een zijn", CategoryId = 2, Price = 9778.59M, ImageName = "abstract.jpg" },
               new Art { Id = 7, ArtistId = 1, Name = "Sloten", Created = DateTime.Now, Description = "is sloten een dit", CategoryId = 3, Price = 3305.63M, ImageName = "sloten.jpg" },
               new Art { Id = 8, ArtistId = 1, Name = "Boor", Created = DateTime.Now, Description = "een boor dit is", CategoryId = 1, Price = 8432.34M, ImageName = "boor.jpg" },
               new Art { Id = 9, ArtistId = 1, Name = "Circle", Created = DateTime.Now, Description = "circle dat geweest een", CategoryId = 0, Price = 5943.54M, ImageName = "circle.jpg" }
           );

            modelBuilder.Entity<Artist>().ToTable("Artists").HasData(
                new { Id = 0, ArtistName = "Pablito", Dob = DateTime.Now, UserId = "0" },
                new { Id = 1, ArtistName = "Jenny", Dob = DateTime.Now, UserId = "1" }
            );

            #warning User Passwords should be removed 
            // 0 = 1234Pasw, 1 = GeneralReaper666, 2 = bob123
            modelBuilder.Entity<IdentityUser>().ToTable("AspNetUsers").HasData(
                new IdentityUser { Id = "0", Email="de__manu09@hotmail.com", PasswordHash= "675d13fc79dc2b90de05b11b36ec388a", UserName = "manu", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = true, LockoutEnabled = false, AccessFailedCount = 1 },
                new IdentityUser { Id = "1", UserName = "VanGimst", PasswordHash= "754f4789adeac685009905e3a5b9c6ef", Email ="random@mailinator.com", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = true, LockoutEnabled = false, AccessFailedCount = 1 },
                new IdentityUser { Id = "2", UserName = "bob", PasswordHash = "2acba7f51acfd4fd5102ad090fc612ee", Email = "bob@gmail.com", EmailConfirmed = true, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = false, AccessFailedCount = 1 }
                );

            modelBuilder.Entity<BearerHistory>().ToTable("BearerHistories").HasData(
                new { Id = 0, BearerToken = "qsdfsdfùqsdlfùqsdmlfùmlsdf", UserId = "0" },
                new { Id = 1, BearerToken = "qsdfsdfùqsdlfùqsdmlfùmlsdf", UserId = "2" }
                );
            #endregion
        }
    }
}
