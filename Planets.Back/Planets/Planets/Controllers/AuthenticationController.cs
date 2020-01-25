using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planets.Data.Models.Views;
using Planets.Data.Repositories;

namespace Planets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationReadRepository _authenticationReadRepository;

        public AuthenticationController(IAuthenticationReadRepository authenticationReadRepository)
        {
            _authenticationReadRepository = authenticationReadRepository;
        }

        [HttpPut("hashedPassword")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<AuthenticationView> Validate(string hashedPassword)
        {
            return await _authenticationReadRepository.ReadAuthentication(hashedPassword);
        }
    }
}
