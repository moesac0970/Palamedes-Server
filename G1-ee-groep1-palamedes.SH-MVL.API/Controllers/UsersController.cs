using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private UserRepository users;
        //#todo get user with art or artists 
        private ArtRepository arts;
        private ArtistsRepository artists;
        public UsersController(UserRepository repo, ArtistsRepository _artists, ArtRepository _arts)
        {
            users = repo;
            arts = _arts;
            artists = _artists;
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await users.GetUsersAsync());
        }

        [HttpGet]
        [Route("userid/{id}")]
        public async Task<IActionResult> GetArtByUserId(string id)
        {
            Artist artist = artists.GetByUserId(id);
            List<Art> artistArts = await arts.GetByArtist(artist);

            return Ok(artistArts);
        }


        //good to have?

        //[HttpGet]
        //[Route("Users/{BearerToken}")]
        //public async Task<IActionResult> GetuserByBearerToken(string BearerToken)
        //{
        //    return Ok(await users.GetUserByBearerAsync(BearerToken));
        //}


    }
}