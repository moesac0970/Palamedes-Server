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

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtsController : Controller
    {
        private IConfiguration Configuration { get; }
        private string baseUri;
        private string artistUri;
        HttpClient httpClient = new HttpClient();

        public ArtsController(IConfiguration configuration)
        {
            Configuration = configuration;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            artistUri = $"{baseUri}artists";
            baseUri += "arts";
        }

        private async Task<Art> JoinArtist(Art art)
        {
            Artist artist = await WebApiHelper.GetApiResultAsync<Artist>($"{artistUri}/{art.ArtistId}");
            art.Artist = artist;
            return art;
        }

        private async Task<IEnumerable<Art>> JoinArtist(IEnumerable<Art> arts)
        {
            IEnumerable<Artist> artists = await WebApiHelper.GetApiResultAsync<List<Artist>>(artistUri);

            foreach (Art art in arts)
            {
                foreach (Artist artist in artists)
                {
                    if (art.ArtistId == artist.Id)
                    {

                        art.Artist = artist;
                    }
                }
            }

            return arts;
        }

        // GET: Admin/Arts
        public async Task<IActionResult> Index()
        {
            IEnumerable<Art> arts = await WebApiHelper.GetApiResultAsync<List<Art>>(baseUri);
            return View(await JoinArtist(arts));
        }

        // GET: Admin/Arts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Art art = await WebApiHelper.GetApiResultAsync<Art>($"{baseUri}/{id}");

            if (art == null)
            {
                return NotFound();
            }

            return View(await JoinArtist(art));
        }

        // GET: Admin/Arts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Arts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,CategoryId,Category,Created,Description,Updated,Price,ImageName,ArtistId,Id")] Art art)
        {
            if (ModelState.IsValid)
            {
                await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, art);
                return RedirectToAction(nameof(Index));
            }
            return View(await JoinArtist(art));
        }

        // GET: Admin/Arts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Art art = await WebApiHelper.GetApiResultAsync<Art>($"{baseUri}/{id}");
            if (art == null)
            {
                return NotFound();
            }
            return View(await JoinArtist(art));
        }

        // POST: Admin/Arts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,CategoryId,Category,Created,Description,Updated,Price,ImageName,ArtistId,Id")] Art art)
        {
            if (id != art.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await WebApiHelper.PutAsJsonAsync(httpClient, $"{baseUri}/{id}", art);
                return RedirectToAction(nameof(Index));
            }
            return View(await JoinArtist(art));
        }

        // GET: Admin/Arts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Art art = await WebApiHelper.GetApiResultAsync<Art>($"{baseUri}/{id}");
            if (art == null)
            {
                return NotFound();
            }

            return View(await JoinArtist(art));
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
            return View();
        }
    }
}
