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
    public class UserController : Controller
    {
        private IConfiguration Configuration { get; }
        private string baseUri;
        HttpClient httpClient = new HttpClient();

        public UserController(IConfiguration configuration)
        {
            Configuration = configuration;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            baseUri += "users";
        }

        // GET: Admin/Arts
        public async Task<IActionResult> Index()
        {
            IEnumerable<User> users = await WebApiHelper.GetApiResultAsync<List<User>>(baseUri);
            return View(users);
        }

        // GET: Admin/Arts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await WebApiHelper.GetApiResultAsync<User>($"{baseUri}/{id}");

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Admin/Arts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Arts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Dob,Email,TelNr,UserName,HashPasw,Id")] User user)
        {
            if (ModelState.IsValid)
            {
                await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Admin/Arts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await WebApiHelper.GetApiResultAsync<User>($"{baseUri}/{id}");
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Admin/Arts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName,Dob,Email,TelNr,UserName,HashPasw,Id")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await WebApiHelper.PutAsJsonAsync(httpClient, $"{baseUri}/{id}", user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Admin/Arts/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await WebApiHelper.GetApiResultAsync<User>($"{baseUri}/{id}");
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Admin/Arts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await WebApiHelper.DelCallAPI<User>($"{baseUri}/{id}");

            try
            {
                User user = await WebApiHelper.GetApiResultAsync<User>($"{baseUri}/{id}");

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
