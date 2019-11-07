using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Data
{
    public class ApplicationDbContext<TUser> : IdentityDbContext<TUser, IdentityRole, string>
                                                             where TUser : IdentityUser
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext<TUser>> options)
            : base(options)
        {
        }

        public DbSet<Art> Arts { get; set; }
        public DbSet<Artistss> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

