using System;
using System.Collections.Generic;
using System.Text;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public int TelNr { get; set; }
        public string UserName { get; set; }
        public string HashPasw { get; set; }
       


        // Unshadowed FK
        public virtual ICollection<UserArt> Arts { get; set; }
    }
}
