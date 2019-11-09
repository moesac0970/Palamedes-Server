using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Models
{
    public class AuthHistory
    {
        public string Token { get; set; } 
        public string UserName { get; set; }
    }
}
