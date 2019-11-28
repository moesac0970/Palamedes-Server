using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Models
{
    public class Art : EntityBase
    {
        public string Name { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public DateTime Updated { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }

        public long ArtistId { get; set; }
        public Artist Artist { get; set; }

    }
}
