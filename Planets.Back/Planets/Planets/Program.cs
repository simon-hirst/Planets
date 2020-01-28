using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Planets.Data;
using Planets.Extensions;
using Planets.StartupTasks;

namespace Planets
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var webHost = CreateWebHostBuilder(args).Build();
            return webHost.RunWithStartupTaskAsync();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
    }
}