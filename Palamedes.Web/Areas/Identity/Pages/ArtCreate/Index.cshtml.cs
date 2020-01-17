using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Palamedes.API.Models;
using Palamedes.Web.Helper;

namespace Palamedes.Web.Areas.Identity.Pages.ArtCreate
{
    public class IndexModel : PageModel
    {
        private IConfiguration Configuration { get; }

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        HttpClient httpClient = new HttpClient();
        public Art Art;
        string baseUri = "";
        string categoryUri = "";
        string usersUri = "";
        public IEnumerable<Category> categories;
        public string ReturnUrl { get; set; }

        public IndexModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            Configuration = configuration;
            categories = new List<Category>();
            this.Art = new Art();
            _userManager = userManager;
            _signInManager = signInManager;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            categoryUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value + "categories";
            usersUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value + "users/artistbyuserid/";
            baseUri += "arts";
        }
        public async Task OnGet(string returnUrl = null)
        {     
            ReturnUrl = returnUrl;
            categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(categoryUri);
        }

        public async Task OnPostAsync(Art art)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(_signInManager.Context.User.Identity.Name);
                Artist artist = new Artist();
                artist =  WebApiHelper.GetApiResult<Artist>(usersUri + user.Id);
                if (artist != null)
                {
                    art.ArtistId = artist.Id;
                    art.Created = DateTime.Now;


                    string token = HttpContext.Request.Cookies["bearerToken"];

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

                    await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, art);

                    LocalRedirect("/PickImage");
                }
                LocalRedirect("home/index");

            }
            LocalRedirect("home/index");
        }
    }
}
