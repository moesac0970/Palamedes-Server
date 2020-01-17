using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Palamedes.API.Models;
using IdentityUser = Microsoft.AspNetCore.Identity.IdentityUser;

namespace Palamedes.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>


    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Artist> Artist { get; set; }

        public DbSet<Art> Art { get; set; }

        public DbSet<User> User { get; set; }
    }
}

