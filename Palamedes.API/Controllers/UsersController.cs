using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Palamedes.API.Models;
using Palamedes.API.Repositories;

namespace Palamedes.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository users;
        //#todo get user with art or artists 
        private readonly ArtRepository arts;
        private readonly ArtistsRepository artists;
        public UsersController(UserRepository repo, ArtistsRepository _artists, ArtRepository _arts)
        {
            users = repo;
            arts = _arts;
            artists = _artists;
        }

        
        [HttpGet]
        [Authorize("RequireAdminRole")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await users.GetUsersAsync());
        }

        [HttpGet]

        [Authorize("RequireMemberRole")]
        [Route("artbyuserid/{id}")]
        public async Task<IActionResult> GetArtByUserId(string id)
        {
            Artist artist = artists.GetByUserId(id);
            List<Art> artistArts = await arts.GetByArtist(artist);

            return Ok(artistArts);
        }

        [HttpGet]
        [Route("artistbyuserid/{id}")]
        public IActionResult GetArtistByUserId(string id)
        {
            Artist artist = artists.GetByUserId(id);

            return Ok(artist);
        }

        [HttpGet]
        [Route("basic/{id}")]
        public async Task<IActionResult> GetArtsBasicByUserId(string id)
        {
            Artist artist = artists.GetByUserId(id);
            var basicArts = await arts.GetBasicsByArtist(artist);

            return Ok(basicArts);
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