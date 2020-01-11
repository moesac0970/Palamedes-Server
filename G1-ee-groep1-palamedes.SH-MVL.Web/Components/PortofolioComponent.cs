using G1_ee_groep1_palamedes.SH_MVL.API.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Components
{
    [ViewComponent(Name = "Portofolio")]
    public class PortofolioComponent : ViewComponent
    {
        public IConfiguration Configuration { get; }
        public string baseUri;
        private IEnumerable<ArtBasic> PublicPortofolio { get; set; }

        public PortofolioComponent(IConfiguration configuration)
        {
            Configuration = configuration;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;

            PublicPortofolio = WebApiHelper.GetApiResult<List<ArtBasic>>(baseUri + "arts/basic");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View(PublicPortofolio));
        }

    }
}
