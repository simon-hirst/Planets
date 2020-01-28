using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Planets.StartupTasks;

namespace Planets.Extensions
{
    public static class StartupTaskExtension
    {
        public static async Task RunWithStartupTaskAsync(this IWebHost webHost, CancellationToken cancellationToken = default)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var startupTask = scope.ServiceProvider.GetService<IStartupTask>();
                await startupTask.ExecuteAsync(cancellationToken);
            }

            await webHost.RunAsync(cancellationToken);
        }
    }
}