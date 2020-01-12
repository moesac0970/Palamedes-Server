using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Identity.Pages.ArtistRegister
{
    public class IndexModel : PageModel
    {
        private IConfiguration Configuration { get; }
        
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        HttpClient httpClient = new HttpClient();
        public Artist artist;
        string baseUri = "";
        public string ReturnUrl { get; set; }

        public IndexModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            Configuration = configuration;
            this.artist = new Artist();
            _userManager = userManager;
            _signInManager = signInManager;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            baseUri += "artists";
        }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task OnPostAsync(Artist artist)
        {
            if (ModelState.IsValid)
            {
                Artist PostArtist = new Artist();
                PostArtist.ArtistName = artist.ArtistName;
                var user = await _userManager.FindByNameAsync(_signInManager.Context.User.Identity.Name);
                PostArtist.UserId = user.Id;

                string token = HttpContext.Request.Cookies["bearerToken"];
                
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
                await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, PostArtist);

                LocalRedirect("~/");
            }
            LocalRedirect("~/");

            

        }
    }
}
