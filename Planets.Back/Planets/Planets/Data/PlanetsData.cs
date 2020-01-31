using System;
using Planets.Models.Entities;

namespace Planets.Data
{
    public class PlanetsData
    {
        public static readonly PlanetEntity[] Planets = 
            new PlanetEntity[]
            {
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Jupiter",
                    Image = "jupiter.png",
                    DistanceFromSun = "5.20",
                    Mass = "1899000",
                    Diameter = "142984"
                },
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Neptune",
                    Image = "neptune.png",
                    DistanceFromSun = "30.1",
                    Mass = "102430",
                    Diameter = "4879"
                },
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Uranus",
                    Image = "uranus.png",
                    DistanceFromSun = "19.2",
                    Mass = "86832",
                    Diameter = "12104"
                },
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Saturn",
                    Image = "saturn.png",
                    DistanceFromSun = "9.58",
                    Mass = "568460",
                    Diameter = "120536"
                },
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Mars",
                    Image = "mars.png",
                    DistanceFromSun = "1.52",
                    Mass = "642",
                    Diameter = "6779"
                },
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Earth",
                    Image = "earth.png",
                    DistanceFromSun = "1",
                    Mass = "5974",
                    Diameter = "12756"
                },
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Venus",
                    Image = "venus.png",
                    DistanceFromSun = "0.722",
                    Mass = "4868",
                    Diameter = "12104"
                },
                new PlanetEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Mercury",
                    Image = "mercury.png",
                    DistanceFromSun = "0.387",
                    Mass = "330",
                    Diameter = "4879"
                }
            };
    }
}