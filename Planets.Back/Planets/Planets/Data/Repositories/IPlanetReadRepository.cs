using Planets.Data.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planets.Data.Repositories
{
    public interface IPlanetReadRepository
    {
        Task<PlanetView> ReadPlanet(Guid id);

        //Task<> ReadPlanets();
    }
}
