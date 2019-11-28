using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
