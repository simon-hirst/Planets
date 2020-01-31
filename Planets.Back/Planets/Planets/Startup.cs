using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Planets.Data;
using Planets.Data.Repositories;
using Planets.Services;

namespace Planets
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PlanetsContext>(options =>
                options.UseSqlite("Data Source=app.db"));
            services.AddControllers();
            services.AddTransient<IPlanetReadRepository, PlanetReadRepository>();
            services.AddTransient<IPlanetWriteRepository, PlanetWriteRepository>();
            services.AddTransient<IAuthenticationReadRepository, AuthenticationReadRepository>();
            
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

            services.AddSingleton<IAuthenticationService>(
                new AuthenticationService(
                    _configuration.GetValue<string>("JWTSecretKey"),
                    _configuration.GetValue<int>("JWTLifespan")
                )
            );
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