using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planets.Data.Models.Views;
using Planets.Data.Repositories;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace Planets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetReadRepository _planetReadRepository;
        private readonly IPlanetWriteRepository _planetWriteRepository;

        public PlanetController(IPlanetReadRepository planetReadRepository, IPlanetWriteRepository planetWriteRepository)
        {
            _planetReadRepository = planetReadRepository;
            _planetWriteRepository = planetWriteRepository;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(Status200OK)]
        [ProducesResponseType(Status404NotFound)]
        public async Task<ActionResult<PlanetView>> GetPlanet(Guid id)
        {
            var planet = await _planetReadRepository.ReadPlanet(id);
            return planet == null ? NotFound("No such planet exist") : new ActionResult<PlanetView>(planet);
        }

        [HttpGet]
        [ProducesResponseType(Status200OK)]
        [ProducesResponseType(Status404NotFound)]
        public async Task<ActionResult<IEnumerable<PlanetView>>> GetAllPlanets()
        {
            var planets = await _planetReadRepository.ReadPlanets();
            return planets == null ? NotFound("No planets exist") : new ActionResult<IEnumerable<PlanetView>>(planets);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PlanetView>> UpdatePlanet(PlanetView planet)
        {
            var planetResult = await _planetWriteRepository.WritePlanet(planet);
            return planetResult == null ? NotFound("No such planet exist") : new ActionResult<PlanetView>(planetResult);
        }
    }
}