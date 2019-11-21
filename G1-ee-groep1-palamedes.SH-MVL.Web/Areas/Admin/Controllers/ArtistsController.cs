using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtistsController : Controller
    {
        private IConfiguration Configuration { get; }
        private string baseUri;
        HttpClient httpClient = new HttpClient();

        public ArtistsController(IConfiguration configuration)
        {
            Configuration = configuration;
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
            return View();
        }

        // POST: Admin/Artists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtistName,Dob,UserId,Id")] Artist artists)
        {
            if (ModelState.IsValid)
            {
                await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, artists);
                return RedirectToAction(nameof(Index));
            }
            return View(artists);
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
        public async Task<IActionResult> Edit(int id, [Bind("ArtistName,Dob,UserId,Id")] Artist artists)
        {
            if (id != artists.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

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
            await WebApiHelper.DelCallAPI<Artist>($"{baseUri}/{id}");

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
