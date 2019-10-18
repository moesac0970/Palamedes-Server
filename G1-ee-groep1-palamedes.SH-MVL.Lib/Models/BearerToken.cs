using System;
using System.Collections.Generic;
using System.Text;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class BearerToken
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }
}
