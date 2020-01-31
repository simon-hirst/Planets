using System.Collections.Generic;
using System.Threading.Tasks;
using Planets.Models.Views;

namespace Planets.Data.Repositories
{
    public interface IPlanetReadRepository
    {
        Task<IEnumerable<PlanetView>> ReadPlanets();
    }
}