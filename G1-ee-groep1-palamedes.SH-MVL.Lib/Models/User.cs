using System;
using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class User : EntityBase
    {
        [DataType(DataType.Text)]
        [StringLength(15, MinimumLength = 3)]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(15, MinimumLength = 3)]
        public string LastName { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public int TelNr { get; set; }

        [DataType(DataType.Text)]
        [StringLength(10, MinimumLength = 4)]
        public string UserName { get; set; }

        public string HashPasw { get; set; }

    }
}
