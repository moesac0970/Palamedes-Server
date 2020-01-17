﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Palamedes.API.Repositories;
using Palamedes.API.Services;

namespace Palamedes.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserRepository db;
        private readonly BearerHistoryRepository BearerRepo;
        public AuthController(UserRepository context, BearerHistoryRepository bearerHistoryRepository)
        {
            db = context;
            BearerRepo = bearerHistoryRepository;
        }

        [HttpPost("token")]
        public async Task<IActionResult> Token()
        {
            //todo: simplify constructor
            BearerTokenService generator = new BearerTokenService(db, BearerRepo);
            var token = await generator.GenerateBearerToken(Request);

            if (token != "not valid user" || token != "wrong request")
            {
                return Ok(token);
            }
            return BadRequest(token);

        }
    }
}