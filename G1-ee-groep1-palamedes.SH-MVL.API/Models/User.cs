using System;
using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Models
{
    public class User : EntityBase
    {
        [DataType(DataType.Text)]
        [StringLength(15, MinimumLength = 3)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(15, MinimumLength = 3)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public int TelNr { get; set; }

        [DataType(DataType.Text)]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Password Hash")]
        public string HashPasw { get; set; }

    }
}
