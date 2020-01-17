using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Palamedes.API.Models;
using Palamedes.Web.Areas.Admin.ViewModels;
using Palamedes.Web.Helper;

namespace Palamedes.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
#nullable enable
    public class UsersController : Controller
    {
        private IConfiguration Configuration;
        private UserManager<IdentityUser> UserManager;
        private HttpClient httpClient = new HttpClient();
        private string token;
        private string artistUri;

        public UsersController(UserManager<IdentityUser> UserManager, IConfiguration configuration)
        {
            this.UserManager = UserManager;
            Configuration = configuration;
            string baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            artistUri = $"{baseUri}artists";
        }

        // GET: Admin/Arts
        public async Task<IActionResult> Index()
        {
            IEnumerable<IdentityUser> users = await UserManager.Users.ToListAsync();
            return View(users);
        }

        // GET: Admin/Arts/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IdentityUser user = await UserManager.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Admin/Arts/Create
        public IActionResult Create()
        {
            UserVm viewmodel = new UserVm();
            IdentityUser user = new IdentityUser();

            viewmodel.User = user;

            return View(viewmodel);
        }

        // POST: Admin/Arts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserVm viewmodel)
        {
            
            IdentityUser user = new IdentityUser();
            if (ModelState.IsValid)
            {
                user = viewmodel.User;

                await UserManager.CreateAsync(user, viewmodel.Password);

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

            IdentityUser user = await UserManager.Users.FirstOrDefaultAsync(u => u.Id == id);
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
            IdentityUser user = await UserManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            IEnumerable<Artist> artists = await WebApiHelper.GetApiResultAsync<List<Artist>>(artistUri);
            long artistId = artists.FirstOrDefault(a => a.UserId == id).Id;
            token = ControllerContext.HttpContext.Request.Cookies["bearerToken"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            await WebApiHelper.DelCallAPI<Artist>(httpClient, $"{artistUri}/{artistId}");

            await UserManager.DeleteAsync(user);

            try
            {
                user = await UserManager.Users.FirstOrDefaultAsync(u => u.Id == id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server error try after some time.");
            return RedirectToAction(nameof(Index));
        }
    }
}
