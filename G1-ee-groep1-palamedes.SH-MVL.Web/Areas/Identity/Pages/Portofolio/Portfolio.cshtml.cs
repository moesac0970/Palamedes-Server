using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Identity.Pages.Portofolio
{
    [Authorize]
    public class PortfolioModel : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public string ID;

        public PortfolioModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task OnGet()
        {
            IdentityUser currentUser;
            if (_signInManager.IsSignedIn(User))
            {
                currentUser = await _userManager.GetUserAsync(User);
                ID = currentUser.Id;
            }
        }
    }
}
