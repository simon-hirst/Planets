﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Views;

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
            var planet = await _dbContext.PlanetsDb.FirstOrDefaultAsync(_planet => _planet.Id == id);
            if (planet != null)
            {
                return new PlanetView
                {
                    Id = planet.Id, Name = planet.Name, Diameter = planet.Diameter, DistanceFromSun = planet.DistanceFromSun,
                    Image = planet.Image, Mass = planet.Mass
                };
            }
            return null;
        }

        public async Task<IEnumerable<PlanetView>> ReadPlanets()
        {
            var planets = _dbContext.PlanetsDb;
            if (await planets.AnyAsync())
            {
                return planets.Select(planet => new PlanetView
                    {
                        Id = planet.Id,
                        Name = planet.Name,
                        Diameter = planet.Diameter,
                        DistanceFromSun = planet.DistanceFromSun,
                        Image = planet.Image,
                        Mass = planet.Mass
                    });
            }
            return null;
        }
    }
}