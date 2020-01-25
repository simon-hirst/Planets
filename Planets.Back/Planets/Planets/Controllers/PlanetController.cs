using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planets.Data.Models.Views;
using Planets.Data.Repositories;

namespace Planets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetReadRepository _planetReadRepository;

        public PlanetController(IPlanetReadRepository planetReadRepository)
        {
            _planetReadRepository = planetReadRepository;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<PlanetView> GetPlanet(Guid id)
        {
            return await _planetReadRepository.ReadPlanet(id);
        }

        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IEnumerable<Planet>> GetAllPlanets()
        //{
        //    return new Object();
        //}

        //[HttpPut("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> UpdatePlanet(Guid id)
        //{
        //    return new Object();
        //}
    }
}
