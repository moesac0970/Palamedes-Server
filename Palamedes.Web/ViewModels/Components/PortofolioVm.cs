using System.ComponentModel.DataAnnotations;

namespace Palamedes.Web.ViewModels.Components
{
    /// <summary>
    /// viewmodel for the portofolio
    /// todo: implementing portofolio specific for each identity
    /// </summary>
    public class PortofolioVm
    {
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3)]
        public string Category { get; set; }

        public ArtistsPortofolioVm Artist { get; set; }

        [DataType(DataType.Text)]
        [StringLength(10)]
        public string Area { get; set; }

        [DataType(DataType.Text)]
        [StringLength(10, MinimumLength = 3)]
        public string Controller { get; set; }

        [DataType(DataType.Text)]
        [StringLength(10, MinimumLength = 3)]
        public string Action { get; set; }
    }
}
