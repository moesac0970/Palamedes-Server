using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserRepository users;
        public UsersController(UserRepository repo)
        {
            users = repo;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await users.GetUsersAsync());
        }
    }
}