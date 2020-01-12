using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.ViewModels
{
    public class ArtistVm
    {
        public Artist Artist { get; set; }

        public IEnumerable<IdentityUser> Users {get; set;}
    }
}
