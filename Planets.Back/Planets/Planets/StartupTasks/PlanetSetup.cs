using System.Threading;
using System.Threading.Tasks;
using Planets.Data.Repositories;

namespace Planets.StartupTasks
{
    public class PlanetSetup : IStartupTask
    {
        private readonly ISetupTaskWriteRepository _setupTaskWriteRepository;

        public PlanetSetup(ISetupTaskWriteRepository setupTaskWriteRepository)
        {
            _setupTaskWriteRepository = setupTaskWriteRepository;
        }

        public async Task ExecuteAsync(CancellationToken cancellationToken = default)
        {
            await SeedDatabase();
        }

        private async Task SeedDatabase()
        {
            await _setupTaskWriteRepository.SeedAsync();
        }
    }
}