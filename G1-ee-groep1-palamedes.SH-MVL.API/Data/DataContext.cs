using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Data
{
    public class DataContext<TUser> : IdentityDbContext<TUser, IdentityRole, string>
                                                             where TUser : IdentityUser
    {
        public DataContext(DbContextOptions<DataContext<TUser>> options): base(options) { }

        // Load Entities
        public DbSet<Art> Arts { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<BearerHistory> BearerHistories { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed data on build
            DataSeeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
