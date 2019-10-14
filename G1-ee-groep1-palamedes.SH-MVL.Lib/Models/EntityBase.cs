using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class EntityBase
    {
        [Required]
        public int Id { get; set; }
    }
}
