using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Palamedes.API.Models;

namespace Palamedes.API.Data
{
    public class DataContext<TUser> : IdentityDbContext<TUser, IdentityRole, string>
                                                             where TUser : IdentityUser
    {
        public DataContext(DbContextOptions<DataContext<TUser>> options) : base(options) { }

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
