using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Identity.Pages.ArtCreate
{
    public class PickImageModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        IConfiguration config;
        string baseUri = "";
        public PickImageModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            config = configuration;
            baseUri = config.GetSection("Data").GetSection("ApiBaseUri").Value;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public void OnGet()
        {
        }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync(IFormFile file)
        {
            var user = await _userManager.FindByNameAsync(_signInManager.Context.User.Identity.Name);
            Artist artist = new Artist();
            artist = WebApiHelper.GetApiResult<Artist>(baseUri+ "users/artistbyuserid/" + user.Id);
            
            baseUri += "arts/ImageArtistName/" + artist.ArtistName;
            HttpClient httpClient = new HttpClient();
            string token = HttpContext.Request.Cookies["bearerToken"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            ////
            
            byte[] data;
            using (var br = new BinaryReader(file.OpenReadStream()))
            {
                data = br.ReadBytes((int)file.OpenReadStream().Length);
            }
            ByteArrayContent bytes = new ByteArrayContent(data);
            MultipartFormDataContent multiContent = new MultipartFormDataContent();
            multiContent.Add(bytes, "file", file.FileName);
            
            var response = await httpClient.PostAsync(baseUri, multiContent);
            return RedirectToAction("Index", "Home");


        }
    }
}
