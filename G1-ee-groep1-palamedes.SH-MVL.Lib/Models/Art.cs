using System;
using System.Collections.Generic;


namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class Art : EntityBase
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public DateTime Updated { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }



        //foreign tables
        public virtual ICollection<UserArt> Users { get; set; }
    }
}
