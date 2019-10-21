using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.DTO
{
    public class ArtDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
        public string ImageName { get; set; }
    }
}
