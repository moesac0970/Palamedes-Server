using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.ViewModels;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtsController : Controller
    {
        private IConfiguration Configuration { get; }
        private readonly string baseUri;
        private string ArtUri { get; set; }
        private string ArtistUri { get; set; }
        private string CategoryUri { get; set; }
        private string Token { get; set; }
        private HttpClient HttpClient = new HttpClient();

        private IEnumerable<Art> arts;
        private IEnumerable<Category> categories;
        private IEnumerable<Artist> artists;

        public ArtsController(IConfiguration configuration)
        {
            Configuration = configuration;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            ArtistUri = $"{baseUri}artists";
            CategoryUri += $"{baseUri}categories";
            ArtUri += $"{baseUri}arts";
        }


        // GET: Admin/Arts
        public async Task<IActionResult> Index()
        {

            arts = await WebApiHelper.GetApiResultAsync<IEnumerable<Art>>(ArtUri);
            return View(arts);
        }

        // GET: Admin/Arts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            arts = await WebApiHelper.GetApiResultAsync<IEnumerable<Art>>(ArtUri);
            Art art = arts.FirstOrDefault(a => a.Id == id);

            if (art == null) return NotFound();
            return View(art);
        }

        // GET: Admin/Arts/Create
        public async Task<IActionResult> Create()
        {
            ArtEditVm viewmodel = new ArtEditVm();
            Art art = new Art();

            viewmodel.Art = art;

            categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(CategoryUri);
            viewmodel.CategoriesList = categories.Select(c => c.Name);

            artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(ArtistUri);
            viewmodel.ArtistsList = artists.Select(a => a.ArtistName);

            return View(viewmodel);
        }

        // POST: Admin/Arts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArtEditVm viewmodel)
        {
            if (ModelState.IsValid)
            {
                Art art = viewmodel.Art;
                artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(ArtistUri);
                categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(CategoryUri);

                art.CategoryId = categories.Where(c => c.Name == art.Category.Name).Select(c => c.Id).First();
                art.ArtistId = artists.Where(a => a.ArtistName == art.Artist.ArtistName).Select(c => c.Id).First();

                Token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", Token);
                await WebApiHelper.PostAsJsonAsync(HttpClient, ArtUri, art);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Arts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ArtEditVm viewmodel = new ArtEditVm();

            if (id == null) return NotFound();

            arts = await WebApiHelper.GetApiResultAsync<IEnumerable<Art>>(ArtUri);
            Art art = arts.FirstOrDefault(a => a.Id == id);

            if (art == null) return NotFound();

            viewmodel.Art = art;

            categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(CategoryUri);
            viewmodel.CategoriesList = categories.Select(c => c.Name);

            artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(ArtistUri);
            viewmodel.ArtistsList = artists.Select(a => a.ArtistName);

            return View(viewmodel);
        }

        // POST: Admin/Arts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ArtEditVm viewmodel)
        {
            Art art = new Art();
            if (id != viewmodel.Art.Id) return NotFound();

            if (ModelState.IsValid)
            {
                artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(ArtistUri);
                categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(CategoryUri);

                art = viewmodel.Art;

                art.CategoryId = categories.Where(c => c.Name == art.Category.Name).Select(c => c.Id).First();
                art.Category = categories.FirstOrDefault(c => c.Name == art.Category.Name);

                art.ArtistId = artists.Where(a => a.ArtistName == art.Artist.ArtistName).Select(c => c.Id).First();
                art.Artist = artists.FirstOrDefault(a => a.ArtistName == art.Artist.ArtistName);

                Token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", Token);
                await WebApiHelper.PutAsJsonAsync(HttpClient, $"{ArtUri}/{id}", art);

                return RedirectToAction(nameof(Index));
            }
            return View(art);
        }

        // GET: Admin/Arts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Art art = await WebApiHelper.GetApiResultAsync<Art>($"{ArtUri}/{id}");

            if (art == null) return NotFound();
            return View(art);
        }

        // POST: Admin/Arts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", Token);
            await WebApiHelper.DelCallAPI<Art>(HttpClient, $"{ArtUri}/{id}");

            try
            {
                Art art = await WebApiHelper.GetApiResultAsync<Art>($"{ArtUri}/{id}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server error try after some time.");
            return RedirectToAction("Index");
        }
    }
}
