using System;
using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class Art : EntityBase
    {
        
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }
        
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        
        [DataType(DataType.ImageUrl)]
        public string ImageName { get; set; }


        public int ArtistId { get; set; }
        public Artists Artist { get; set; }

    }
}
