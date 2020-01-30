using System;

namespace Planets.Data.Models.Entities
{
    public class PlanetEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string DistanceFromSun { get; set; }
        public string Mass { get; set; }
        public string Diameter { get; set; }
    }
}