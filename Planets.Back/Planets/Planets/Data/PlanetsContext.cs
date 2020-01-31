using Microsoft.EntityFrameworkCore;
using Planets.Models.Entities;

namespace Planets.Data
{
    public class PlanetsContext : DbContext
    {
        public DbSet<PlanetEntity> PlanetsDb { get; set; }
        public DbSet<AuthenticationEntity> AuthenticationDb { get; set; }

        public PlanetsContext(DbContextOptions<PlanetsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanetEntity>().
                HasData(PlanetsData.Planets);
            modelBuilder.Entity<AuthenticationEntity>().
                HasData(AuthenticationData.Authentication);
        }
    }
}