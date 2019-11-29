using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.DTO
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
        public Artist Artist { get; set; }
    }
}
