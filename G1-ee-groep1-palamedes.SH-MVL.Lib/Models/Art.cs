using System;
using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Models
{
    public class Art : EntityBase
    {

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        public Category Category { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Display(Name = "Image name")]
        [DataType(DataType.ImageUrl)]
        public string ImageName { get; set; }


        public int ArtistId { get; set; }

        [Display(Name = "Made by")]
        public Artists Artist { get; set; }
    }
}