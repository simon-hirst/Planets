using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Planets.Extensions;

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