using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planets.Data.Repositories;
using Planets.Models.Views;
using Planets.Services;

namespace Planets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationReadRepository _authenticationReadRepository;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationReadRepository authenticationReadRepository, IAuthenticationService authenticationService)
        {
            _authenticationReadRepository = authenticationReadRepository;
            _authenticationService = authenticationService;
        }

        [HttpPut]
        public async Task<ActionResult<AuthenticationView>> AuthenticateUser([FromBody]LoginView login)
        {
            if (!await _authenticationReadRepository.Verify(login))
            {
                return BadRequest("Invalid password.");
            }

            return _authenticationService.GetAuthenticationData(Guid.NewGuid().ToString());
        }
    }
}