using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Planets.Data;
using Planets.Data.Repositories;
using Planets.StartupTasks;

namespace Planets
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PlanetsContext>(options =>
                options.UseSqlServer(_configuration["SqlDbConnectionString"]));
            services.AddControllers();
            services.AddTransient<IPlanetReadRepository, PlanetReadRepository>();
            services.AddTransient<IAuthenticationReadRepository, AuthenticationReadRepository>();
            services.AddTransient<IPlanetWriteRepository, PlanetWriteRepository>();
            services.AddTransient<ISetupTaskWriteRepository, SetupTaskWriteRepository>();
            services.AddTransient<IStartupTask, PlanetSetup>();
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseCors(MyAllowSpecificOrigins);
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}