using G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels.Components;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Components
{
    [ViewComponent(Name = "Portofolio")]
    public class PortofolioComponent : ViewComponent
    {
        private IEnumerable<PortofolioVm> publicPortofolio { get; set; }
        private IEnumerable<PortofolioVm> userPortofolio { get; set; }


        public PortofolioComponent()
        {
            publicPortofolio = new List<PortofolioVm> // todo: actions and controllers, area {public}
            {
                new PortofolioVm { Name = "dummy1", Artist ="pabloPicasso", Category="design"}, 
                new PortofolioVm { Name = "dummy2", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy3", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy4", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy5", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy6", Artist ="pabloPicasso", Category="design"},
            };

            userPortofolio = new List<PortofolioVm> // todo: actions and controllers, area {user}
            {
                new PortofolioVm { Name = "dummy1", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy2", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy3", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy4", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy5", Artist ="pabloPicasso", Category="design"},
                new PortofolioVm { Name = "dummy6", Artist ="pabloPicasso", Category="design"},
            };
        }

        /// <summary>
        ///   TODO: portofolio components for only users
        ///   TODO: component in andere vorm moest not users only
        /// </summary>



        public async Task<IViewComponentResult> InvokeAsync()
        {
            var portofolio = publicPortofolio;
            return await Task.FromResult<IViewComponentResult>(View(portofolio));
        }

    }
}
