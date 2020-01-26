using System;

namespace Planets.Data.Models.Views
{
    public class PlanetView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string DistanceFromSun { get; set; }
        public string Mass { get; set; }
        public string Diameter { get; set; }
    }
}