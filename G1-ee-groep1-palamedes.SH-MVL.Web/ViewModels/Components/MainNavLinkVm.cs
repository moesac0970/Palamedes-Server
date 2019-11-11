using System.ComponentModel.DataAnnotations;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels.Components
{
    public class MainNavLinkVm
    {
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Text { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Area { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2)]
        public string Controller { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2)]
        public string Action { get; set; }
        
        public bool IsActive { get; set; }
    }
}
