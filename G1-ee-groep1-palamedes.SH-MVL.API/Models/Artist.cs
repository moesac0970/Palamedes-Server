using Microsoft.AspNetCore.Identity;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Models
{
    public class Artist : EntityBase
    {

        public string ArtistName { get; set; }
        public DateTime Dob { get; set; }

        // relations
        public IdentityUser User { get; set; }
        public string UserId { get; set; }

    }
}
