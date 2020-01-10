using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.Web.Data;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.ViewModels;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtsController : Controller
    {
        private IConfiguration Configuration { get; }
        private string baseUri;
        private string artistUri;
        private string categoryUri;
        HttpClient httpClient = new HttpClient();

        private IEnumerable<Art> arts;
        private IEnumerable<Category> categories;
        private IEnumerable<Artist> artists;

        public ArtsController(IConfiguration configuration)
        {
            Configuration = configuration;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            artistUri = $"{baseUri}artists";
            categoryUri = $"{baseUri}categories";
            baseUri += "arts";
        }

        public async void UpdateValues()
        {
            arts = await WebApiHelper.GetApiResultAsync<IEnumerable<Art>>(baseUri);
            categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(categoryUri);
            artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(artistUri);
        } 
        
        // GET: Admin/Arts
        public async Task<IActionResult> Index()
        {
            arts = await WebApiHelper.GetApiResultAsync<IEnumerable<Art>>(baseUri);
            return View(arts);
        }

        // GET: Admin/Arts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            arts = await WebApiHelper.GetApiResultAsync<IEnumerable<Art>>(baseUri);
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
            
            categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(categoryUri);
            viewmodel.CategoriesList = categories.Select(c => c.Name);

            artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(artistUri);
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
                artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(artistUri);
                categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(categoryUri);

                art.CategoryId = categories.Where(c => c.Name == art.Category.Name).Select(c => c.Id).First();
                art.ArtistId = artists.Where(a => a.ArtistName == art.Artist.ArtistName).Select(c => c.Id).First();

                await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, art);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Arts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ArtEditVm viewmodel = new ArtEditVm();

            if (id == null) return NotFound();

            arts = await WebApiHelper.GetApiResultAsync<IEnumerable<Art>>(baseUri);
            Art art = arts.FirstOrDefault(a => a.Id == id);

            if (art == null) return NotFound();

            viewmodel.Art = art;
            
            categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(categoryUri);
            viewmodel.CategoriesList = categories.Select(c => c.Name);
            
            artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(artistUri);
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
                art = viewmodel.Art;
                artists = await WebApiHelper.GetApiResultAsync<IEnumerable<Artist>>(artistUri);
                categories = await WebApiHelper.GetApiResultAsync<IEnumerable<Category>>(categoryUri);
                
                art.CategoryId = categories.Where(c => c.Name == art.Category.Name).Select(c => c.Id).First();
                art.Category = categories.FirstOrDefault(c => c.Name == art.Category.Name);
                art.ArtistId = artists.Where(a => a.ArtistName == art.Artist.ArtistName).Select(c => c.Id).First();
                art.Artist = artists.FirstOrDefault(a => a.ArtistName == art.Artist.ArtistName);

                await WebApiHelper.PutAsJsonAsync(httpClient, $"{baseUri}/{id}", art);
                return RedirectToAction(nameof(Index));
            }
            return View(art);
        }

        // GET: Admin/Arts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Art art = await WebApiHelper.GetApiResultAsync<Art>($"{baseUri}/{id}");
            
            if (art == null) return NotFound();
            return View(art);
        }

        // POST: Admin/Arts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await WebApiHelper.DelCallAPI<Art>($"{baseUri}/{id}");

            try
            {
                Art art = await WebApiHelper.GetApiResultAsync<Art>($"{baseUri}/{id}");

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
