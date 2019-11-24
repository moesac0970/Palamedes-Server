using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using IdentityUser = Microsoft.AspNetCore.Identity.IdentityUser;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Data
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

        public DbSet<G1_ee_groep1_palamedes.SH_MVL.API.Models.Artist> Artist { get; set; }

        public DbSet<G1_ee_groep1_palamedes.SH_MVL.API.Models.Art> Art { get; set; }

        public DbSet<G1_ee_groep1_palamedes.SH_MVL.API.Models.User> User { get; set; }
    }
}

