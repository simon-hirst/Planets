using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planets.Data.Models.Entities
{
    public class PlanetEntity
    {
        public Guid id { get; set; }
        public string image { get; set; }
        public string distanceFromSun { get; set; }
        public string mass { get; set; }
        public string diameter { get; set; }
    }
}
