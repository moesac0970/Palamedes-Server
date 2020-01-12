using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.ViewModels;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtistsController : Controller
    {
        private IConfiguration Configuration { get; } 
        private string baseUri;
        private string token;
        HttpClient httpClient = new HttpClient();
        UserManager<IdentityUser> userManager;

        public ArtistsController(IConfiguration configuration, UserManager<IdentityUser> userMngr)
        {
            Configuration = configuration;
            this.userManager = userMngr;            
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            baseUri += "artists";
        }

        // GET: Admin/Artists
        public async Task<IActionResult> Index()
        {
            IEnumerable<Artist> artists = await WebApiHelper.GetApiResultAsync<List<Artist>>(baseUri);
            return View(artists);
        }

        // GET: Admin/Artists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artist artists = await WebApiHelper.GetApiResultAsync<Artist>($"{baseUri}/{id}");

            if (artists == null)
            {
                return NotFound();
            }

            return View(artists);
        }

        // GET: Admin/Artists/Create
        public IActionResult Create()
        {
            ArtistVm viewmodel = new ArtistVm();

            viewmodel.Users = userManager.Users;
            return View(viewmodel);
        }

        // POST: Admin/Artists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArtistVm viewmodel)
        {
            if (ModelState.IsValid)
            {
                token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
                await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, viewmodel);

                return RedirectToAction(nameof(Index));
            }
            return View(viewmodel);
        }

        // GET: Admin/Artists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artist artists = await WebApiHelper.GetApiResultAsync<Artist>($"{baseUri}/{id}");
            if (artists == null)
            {
                return NotFound();
            }
            return View(artists);
        }

        // POST: Admin/Artists/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtistName,Dob,Id")] Artist artists)
        {
            if (id != artists.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
                await WebApiHelper.PutAsJsonAsync(httpClient, $"{baseUri}/{id}", artists);

                return RedirectToAction(nameof(Index));
            }
            return View(artists);
        }

        // GET: Admin/Artists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artist artists = await WebApiHelper.GetApiResultAsync<Artist>($"{baseUri}/{id}");
            if (artists == null)
            {
                return NotFound();
            }

            return View(artists);
        }

        // POST: Admin/Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            await WebApiHelper.DelCallAPI<Artist>(httpClient, $"{baseUri}/{id}");

            try
            {
                Artist artists = await WebApiHelper.GetApiResultAsync<Artist>($"{baseUri}/{id}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server error try after some time.");
            return View();
        }
    }
}
