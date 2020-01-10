//[Bind("SecurityStamp,PhoneNumberConfirmed,PhoneNumber,PasswordHash,NormalizedUserName,NormalizedEmail,LockoutEnd,LockoutEnabled,Id,EmailConfirmed,Email,ConcurrencyStamp,AccessFailedCount,TwoFactorEnabled,UserName")]

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
using System.Net.Http.Headers;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    #nullable enable
    public class UserController : Controller
    {
        private IConfiguration Configuration { get; }
        private string baseUri;
        HttpClient httpClient = new HttpClient();
        private string token;

        public UserController(IConfiguration configuration)
        {
            Configuration = configuration;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            baseUri += "users";

            token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
        }

        // GET: Admin/Arts
        public async Task<IActionResult> Index()
        {
            IEnumerable<User> users = await WebApiHelper.GetApiResultAsync<List<User>>(baseUri);
            return View(users);
        }

        // GET: Admin/Arts/Details/5
        public async Task<IActionResult> Details(string? id)
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
        public async Task<IActionResult> Create([Bind("SecurityStamp,PhoneNumberConfirmed,PhoneNumber,PasswordHash,NormalizedUserName,NormalizedEmail,LockoutEnd,LockoutEnabled,Id,EmailConfirmed,Email,ConcurrencyStamp,AccessFailedCount,TwoFactorEnabled,UserName")] User user)
        {
            if (ModelState.IsValid)
            {
                await WebApiHelper.PostAsJsonAsync(httpClient, baseUri, user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Admin/Arts/Edit/5
        public async Task<IActionResult> Edit(string? id)
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
        public async Task<IActionResult> Edit(string id, [Bind("SecurityStamp,PhoneNumberConfirmed,PhoneNumber,PasswordHash,NormalizedUserName,NormalizedEmail,LockoutEnd,LockoutEnabled,Id,EmailConfirmed,Email,ConcurrencyStamp,AccessFailedCount,TwoFactorEnabled,UserName")] User user)
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
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await WebApiHelper.DelCallAPI<User>(httpClient, $"{baseUri}/{id}");

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
