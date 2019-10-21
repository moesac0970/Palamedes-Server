using G1_ee_groep1_palamedes.SH_MVL.Lib.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels.Components;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Components
{
    [ViewComponent(Name = "Portofolio")]
    public class PortofolioComponent : ViewComponent
    {
        private IEnumerable<ArtBasic> publicPortofolio { get; set; }
        //private IEnumerable<ArtBasic> userPortofolio { get; set; }


        public PortofolioComponent()
        {
            publicPortofolio = WebApiHelper.GetApiResult<List<ArtBasic>>("http://localhost:5000/api/arts/basic");
        }

        /// <summary>
        ///   TODO: portofolio components for only users
        ///   TODO: list all portofolio items, list limited
        /// </summary>



        public async Task<IViewComponentResult> InvokeAsync()
        {
            var portofolio = publicPortofolio;
            return await Task.FromResult<IViewComponentResult>(View(portofolio));
        }

    }
}
