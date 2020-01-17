using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Palamedes.Web.Areas.Identity.Pages.Portofolio
{
    [Authorize]
    public class PortfolioModel : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public string ID;
        public string apiUri;
        IConfiguration config;
        public PortfolioModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            config = configuration;
            apiUri = config.GetSection("Data").GetSection("ApiBaseUri").Value;
            apiUri += "artbyuserid/";
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
