using G1_ee_groep1_palamedes.SH_MVL.Lib.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Components
{
    [ViewComponent(Name = "Portofolio")]
    public class PortofolioComponent : ViewComponent
    {
        private IEnumerable<ArtBasic> PublicPortofolio { get; set; }

        public PortofolioComponent()
        {
            LoadPortofolioAsync().Wait();
        }

        public async Task LoadPortofolioAsync()
        {
            PublicPortofolio = await WebApiHelper.GetApiResultAsync<List<ArtBasic>>("https://api.palamedes.be/arts/basic");
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View(PublicPortofolio));
        }

    }
}
