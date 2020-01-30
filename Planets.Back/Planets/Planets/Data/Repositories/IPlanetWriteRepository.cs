using System.Threading.Tasks;
using Planets.Data.Models.Views;

namespace Planets.Data.Repositories
{
    public interface IPlanetWriteRepository
    {
        Task<PlanetView> WritePlanet(PlanetView planet);
    }
}