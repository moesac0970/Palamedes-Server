using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels
{
    public class ArtistsPortofolioVm : EntityBase
    {
        public string ArtistName { get; set; }
        public DateTime Dob { get; set; }

        public IdentityUser User { get; set; }

    }
}
