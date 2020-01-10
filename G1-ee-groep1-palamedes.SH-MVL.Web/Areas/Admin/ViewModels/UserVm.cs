using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.ViewModels
{
    public class UserVm
    {
        public IdentityUser User { get; set; }
        public string Password { get; set; }
    }
}
