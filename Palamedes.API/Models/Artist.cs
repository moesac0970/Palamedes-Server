using System;
using Microsoft.AspNetCore.Identity;

namespace Palamedes.API.Models
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
