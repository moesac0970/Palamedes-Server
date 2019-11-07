using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels.Components
{
    /// <summary>
    /// viewmodel for the portofolio
    /// todo: implementing portofolio specific for each identity
    /// </summary>
    public class PortofolioVm
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public Artistss Artist { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
