using System;
using Microsoft.AspNetCore.Identity;
using Palamedes.API.Models;

namespace Palamedes.Web.ViewModels
{
    public class ArtistsPortofolioVm : EntityBase
    {
        public string ArtistName { get; set; }
        public DateTime Dob { get; set; }

        public IdentityUser User { get; set; }

    }
}
