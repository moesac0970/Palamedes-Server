using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerCrudBase<User, UserRepository>
    {

        public UsersController(UserRepository UserRepository) : base(UserRepository)
        {

        }

    }
}