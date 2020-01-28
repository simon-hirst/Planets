using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Views;

namespace Planets.Data.Repositories
{
    public class PlanetWriteRepository : IPlanetWriteRepository
    {
        private readonly PlanetsContext _dbContext;

        public PlanetWriteRepository(PlanetsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<PlanetView> WritePlanet(PlanetView planet)
        {
            var persistedPlanet = await _dbContext.PlanetsDb.FirstOrDefaultAsync(entity => entity.Id == planet.Id);
            if (persistedPlanet == null) return null;
            persistedPlanet.Diameter = planet.Diameter;
            persistedPlanet.Image = planet.Image;
            persistedPlanet.Mass = planet.Mass;
            persistedPlanet.DistanceFromSun = planet.DistanceFromSun;
            persistedPlanet.Name = planet.Name;
            _dbContext.PlanetsDb.Update(persistedPlanet);
            await _dbContext.SaveChangesAsync();
            return new PlanetView
            {
                Id = persistedPlanet.Id, Name = persistedPlanet.Name, Diameter = persistedPlanet.Diameter, DistanceFromSun = persistedPlanet.DistanceFromSun,
                Image = persistedPlanet.Image, Mass = persistedPlanet.Mass
            };

        }
    }
}