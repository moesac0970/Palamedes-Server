using Microsoft.AspNetCore.Identity;

namespace Palamedes.API.Models
{
    public class BearerHistory : EntityBase
    {
        public string BearerToken { get; set; }


        // relations
        public IdentityUser User { get; set; }
        public string UserId { get; set; }

    }
}
