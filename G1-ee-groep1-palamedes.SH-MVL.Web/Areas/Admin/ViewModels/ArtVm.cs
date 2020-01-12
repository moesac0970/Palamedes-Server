using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using System.Collections.Generic;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.ViewModels
{
    public class ArtVm
    {
        public Art Art { get; set; }
        public IEnumerable<string> CategoriesList { get; set; }
        public IEnumerable<string> ArtistsList { get; set; }
    }
}
