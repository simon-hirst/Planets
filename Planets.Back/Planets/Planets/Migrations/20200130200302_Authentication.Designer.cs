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
    [Migration("20200130200302_Authentication")]
    partial class Authentication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Planets.Data.Models.Entities.AuthenticationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AuthenticationDb");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2c44b7e-cd6f-45c6-8536-8ccf0faacb4c"),
                            Password = "DootrixTest"
                        });
                });

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
                            Id = new Guid("289db1a3-e6d5-464e-bbfc-b0a614a100ef"),
                            Diameter = "142984",
                            DistanceFromSun = "5.20",
                            Image = "jupiter.png",
                            Mass = "1899000",
                            Name = "Jupiter"
                        },
                        new
                        {
                            Id = new Guid("487a60b1-c908-416f-8ac3-c2448acbc9db"),
                            Diameter = "4879",
                            DistanceFromSun = "30.1",
                            Image = "neptune.png",
                            Mass = "102430",
                            Name = "Neptune"
                        },
                        new
                        {
                            Id = new Guid("844bd9a7-6ad2-45d8-8efc-19794c99e89f"),
                            Diameter = "12104",
                            DistanceFromSun = "19.2",
                            Image = "uranus.png",
                            Mass = "86832",
                            Name = "Uranus"
                        },
                        new
                        {
                            Id = new Guid("a6eb2c70-3b9c-4ecd-b047-6f33cd194350"),
                            Diameter = "120536",
                            DistanceFromSun = "9.58",
                            Image = "saturn.png",
                            Mass = "568460",
                            Name = "Saturn"
                        },
                        new
                        {
                            Id = new Guid("9726964e-4d9a-42c4-abff-866d44a9f8ba"),
                            Diameter = "6779",
                            DistanceFromSun = "1.52",
                            Image = "mars.png",
                            Mass = "642",
                            Name = "Mars"
                        },
                        new
                        {
                            Id = new Guid("10708304-4db5-4d98-966f-0427476720ba"),
                            Diameter = "12756",
                            DistanceFromSun = "1",
                            Image = "earth.png",
                            Mass = "5974",
                            Name = "Earth"
                        },
                        new
                        {
                            Id = new Guid("6da3edb0-7e29-4b9e-bf53-0982eb513bad"),
                            Diameter = "12104",
                            DistanceFromSun = "0.722",
                            Image = "venus.png",
                            Mass = "4868",
                            Name = "Venus"
                        },
                        new
                        {
                            Id = new Guid("ad3781f2-450a-4bd2-a586-07cc9e5123b2"),
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
