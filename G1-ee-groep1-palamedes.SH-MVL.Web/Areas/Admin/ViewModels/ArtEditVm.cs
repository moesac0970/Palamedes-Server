using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.ViewModels
{
    public class ArtEditVm
    {
        public Art Art { get; set; }
        public IEnumerable<string> CategoriesList { get; set; }

        public IEnumerable<string> ArtistsList { get; set; }
    }
}
