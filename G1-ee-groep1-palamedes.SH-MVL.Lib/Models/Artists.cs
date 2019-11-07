using System;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class Artists : EntityBase
    {
        public string ArtistName { get; set; }
        public DateTime Dob { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
