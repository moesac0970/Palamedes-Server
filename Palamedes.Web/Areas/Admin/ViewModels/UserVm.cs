using Microsoft.AspNetCore.Identity;

namespace Palamedes.Web.Areas.Admin.ViewModels
{
    public class UserVm
    {
        public IdentityUser User { get; set; }
        public string Password { get; set; }
    }
}
