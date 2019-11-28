using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Models
{
    public class BearerHistory : EntityBase
    {
        public string BearerToken { get; set;}


        // relations
        public IdentityUser User { get; set; }
        public string UserId { get; set; }

    }
}
