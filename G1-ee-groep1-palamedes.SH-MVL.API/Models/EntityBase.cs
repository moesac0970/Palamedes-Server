using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Models
{
    public class EntityBase
    {
        [Required]
        public long Id { get; set; }
    }
}
