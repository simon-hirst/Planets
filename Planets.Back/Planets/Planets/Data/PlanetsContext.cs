using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Entities;

namespace Planets.Data
{
    public class PlanetsContext : DbContext
    {
        public DbSet<PlanetEntity> PlanetsDb { get; set; }

        public PlanetsContext(DbContextOptions<PlanetsContext> options) : base(options)
        {
            
        }
        
        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanetEntity>().
                HasData(PlanetsData.Planets);
        }
        #endregion
    }
}