using System.Threading;
using System.Threading.Tasks;

namespace Planets.StartupTasks
{
    public interface IStartupTask
    {
        Task ExecuteAsync(CancellationToken cancellationToken = default);
    }
}