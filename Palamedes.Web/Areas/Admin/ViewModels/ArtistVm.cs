using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Palamedes.API.Models;

namespace Palamedes.Web.Areas.Admin.ViewModels
{
    public class ArtistVm
    {
        public Artist Artist { get; set; }

        public IEnumerable<IdentityUser> Users {get; set;}
    }
}
