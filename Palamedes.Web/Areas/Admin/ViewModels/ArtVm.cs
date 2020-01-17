using System.Collections.Generic;
using Palamedes.API.Models;

namespace Palamedes.Web.Areas.Admin.ViewModels
{
    public class ArtVm
    {
        public Art Art { get; set; }
        public IEnumerable<string> CategoriesList { get; set; }
        public IEnumerable<string> ArtistsList { get; set; }
    }
}
