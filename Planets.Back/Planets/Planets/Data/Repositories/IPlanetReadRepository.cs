using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Planets.Data.Models.Views;

namespace Planets.Data.Repositories
{
    public interface IPlanetReadRepository
    {
        Task<PlanetView> ReadPlanet(Guid id);

        Task<IEnumerable<PlanetView>> ReadPlanets();
    }
}