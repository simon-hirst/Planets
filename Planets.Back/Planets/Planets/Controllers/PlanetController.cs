using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Planets.Data.Models.Views;
using Planets.Data.Repositories;
using Planets.Validators;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace Planets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetReadRepository _planetReadRepository;
        private readonly IPlanetWriteRepository _planetWriteRepository;

        public PlanetController(IPlanetReadRepository planetReadRepository,
            IPlanetWriteRepository planetWriteRepository)
        {
            _planetReadRepository = planetReadRepository;
            _planetWriteRepository = planetWriteRepository;
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
        [ProducesResponseType(Status200OK)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(Status404NotFound)]
        [ProducesResponseType(Status400BadRequest)]
        public async Task<ActionResult<PlanetView>> UpdatePlanet(PlanetView planet)
        {
            var validationResult = new PlanetViewValidator().Validate(planet);
            if (!validationResult.IsValid)
            {
                var errorList = validationResult.Errors.Select(error => error.ErrorMessage);
                return BadRequest(errorList);
            }
            var planetResult = await _planetWriteRepository.WritePlanet(planet);
            return planetResult == null ? NotFound("No such planet exist") : new ActionResult<PlanetView>(planetResult);
        }
    }
}