﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planets.Data;

namespace Planets.Migrations
{
    [DbContext(typeof(PlanetsContext))]
    [Migration("20200130164723_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Planets.Data.Models.Entities.PlanetEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diameter")
                        .HasColumnType("TEXT");

                    b.Property<string>("DistanceFromSun")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mass")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PlanetsDb");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e7b48cfb-9342-42c7-930d-d6d13ef01653"),
                            Diameter = "142984",
                            DistanceFromSun = "5.20",
                            Image = "jupiter.png",
                            Mass = "1899000",
                            Name = "Jupiter"
                        },
                        new
                        {
                            Id = new Guid("0c61fdc2-60b4-4f25-8bb9-9617be833928"),
                            Diameter = "4879",
                            DistanceFromSun = "30.1",
                            Image = "neptune.png",
                            Mass = "102430",
                            Name = "Neptune"
                        },
                        new
                        {
                            Id = new Guid("ec5216c8-cf83-4d27-a8da-74b4ab9b8e5e"),
                            Diameter = "12104",
                            DistanceFromSun = "19.2",
                            Image = "uranus.png",
                            Mass = "86832",
                            Name = "Uranus"
                        },
                        new
                        {
                            Id = new Guid("b2bb63e6-cb9e-480d-8b9a-4e0b4d22dce6"),
                            Diameter = "120536",
                            DistanceFromSun = "9.58",
                            Image = "saturn.png",
                            Mass = "568460",
                            Name = "Saturn"
                        },
                        new
                        {
                            Id = new Guid("cb9067ec-5ccc-4a39-8774-874b687fdae9"),
                            Diameter = "6779",
                            DistanceFromSun = "1.52",
                            Image = "mars.png",
                            Mass = "642",
                            Name = "Mars"
                        },
                        new
                        {
                            Id = new Guid("e83b2536-2297-4e0f-b86f-c84c6203215a"),
                            Diameter = "12756",
                            DistanceFromSun = "1",
                            Image = "earth.png",
                            Mass = "5974",
                            Name = "Earth"
                        },
                        new
                        {
                            Id = new Guid("5950ca5c-9845-4ae9-bb6f-769d62591db4"),
                            Diameter = "12104",
                            DistanceFromSun = "0.722",
                            Image = "venus.png",
                            Mass = "4868",
                            Name = "Venus"
                        },
                        new
                        {
                            Id = new Guid("d227f1dc-d571-4e90-a274-a179294fb01b"),
                            Diameter = "4879",
                            DistanceFromSun = "0.387",
                            Image = "mercury.png",
                            Mass = "330",
                            Name = "Mercury"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
