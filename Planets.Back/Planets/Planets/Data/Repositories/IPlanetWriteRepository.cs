using System.Threading.Tasks;
using Planets.Models.Views;

namespace Planets.Data.Repositories
{
    public interface IPlanetWriteRepository
    {
        Task<PlanetView> WritePlanet(PlanetView planet);
    }
}