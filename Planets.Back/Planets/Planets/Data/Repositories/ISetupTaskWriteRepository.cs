using System.Threading.Tasks;

namespace Planets.Data.Repositories
{
    public interface ISetupTaskWriteRepository
    {
        Task SeedAsync();
    }
}