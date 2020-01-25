using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planets.Data.Repositories
{
    public class PlanetReadRepository : IPlanetReadRepository
    {
        private readonly PlanetsContext _dbContext;

        public PlanetReadRepository(PlanetsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PlanetView> ReadPlanet(Guid id)
        {
            var result = await _dbContext.PlanetsDb.FirstOrDefaultAsync(planet => planet.id == id);
            return new PlanetView { id = result.id, diameter = result.diameter, distanceFromSun = result.distanceFromSun,
            image = result.image, mass = result.mass};
        }

        //public async Task<> ReadPlanets()
        //{

        //}
    }
}
