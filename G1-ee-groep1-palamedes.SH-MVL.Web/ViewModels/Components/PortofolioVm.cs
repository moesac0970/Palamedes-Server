using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels.Components
{
    public class PortofolioVm
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public Artists Artist { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
