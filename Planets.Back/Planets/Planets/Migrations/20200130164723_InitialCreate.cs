using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Planets.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanetsDb",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DistanceFromSun = table.Column<string>(nullable: true),
                    Mass = table.Column<string>(nullable: true),
                    Diameter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetsDb", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("e7b48cfb-9342-42c7-930d-d6d13ef01653"), "142984", "5.20", "jupiter.png", "1899000", "Jupiter" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("0c61fdc2-60b4-4f25-8bb9-9617be833928"), "4879", "30.1", "neptune.png", "102430", "Neptune" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("ec5216c8-cf83-4d27-a8da-74b4ab9b8e5e"), "12104", "19.2", "uranus.png", "86832", "Uranus" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("b2bb63e6-cb9e-480d-8b9a-4e0b4d22dce6"), "120536", "9.58", "saturn.png", "568460", "Saturn" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("cb9067ec-5ccc-4a39-8774-874b687fdae9"), "6779", "1.52", "mars.png", "642", "Mars" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("e83b2536-2297-4e0f-b86f-c84c6203215a"), "12756", "1", "earth.png", "5974", "Earth" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("5950ca5c-9845-4ae9-bb6f-769d62591db4"), "12104", "0.722", "venus.png", "4868", "Venus" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("d227f1dc-d571-4e90-a274-a179294fb01b"), "4879", "0.387", "mercury.png", "330", "Mercury" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanetsDb");
        }
    }
}
