using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class EntityBase
    {
        [Required]
        [Display(Name = "Unique Identifier")]
        public int Id { get; set; }
    }
}
