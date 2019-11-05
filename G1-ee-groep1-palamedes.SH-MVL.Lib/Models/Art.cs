using System;


namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class Art : EntityBase
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public DateTime Updated { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }

        public int ArtistId { get; set; }
        public Artists Artist { get; set; }

    }
}
