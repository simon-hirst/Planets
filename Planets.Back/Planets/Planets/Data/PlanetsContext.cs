using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Entities;

namespace Planets.Data
{
    public class PlanetsContext : DbContext
    {
        public PlanetsContext(DbContextOptions<PlanetsContext> options) : base(options)
        {
        }

        public DbSet<PlanetEntity> PlanetsDb { get; set; }
        public DbSet<AuthenticationEntity> AuthenticationDb { get; set; }
    }
}