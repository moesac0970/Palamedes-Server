using System;
using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class Artists : EntityBase
    {
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2)]
        public string ArtistName { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }
        
        public int UserId { get; set; }
        
        public User User { get; set; }
    }
}
