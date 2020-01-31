using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Planets.Migrations
{
    public partial class Authentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("0c61fdc2-60b4-4f25-8bb9-9617be833928"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("5950ca5c-9845-4ae9-bb6f-769d62591db4"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("b2bb63e6-cb9e-480d-8b9a-4e0b4d22dce6"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("cb9067ec-5ccc-4a39-8774-874b687fdae9"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("d227f1dc-d571-4e90-a274-a179294fb01b"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("e7b48cfb-9342-42c7-930d-d6d13ef01653"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("e83b2536-2297-4e0f-b86f-c84c6203215a"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("ec5216c8-cf83-4d27-a8da-74b4ab9b8e5e"));

            migrationBuilder.CreateTable(
                name: "AuthenticationDb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthenticationDb", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AuthenticationDb",
                columns: new[] { "Id", "Password" },
                values: new object[] { new Guid("a2c44b7e-cd6f-45c6-8536-8ccf0faacb4c"), "DootrixTest" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("289db1a3-e6d5-464e-bbfc-b0a614a100ef"), "142984", "5.20", "jupiter.png", "1899000", "Jupiter" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("487a60b1-c908-416f-8ac3-c2448acbc9db"), "4879", "30.1", "neptune.png", "102430", "Neptune" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("844bd9a7-6ad2-45d8-8efc-19794c99e89f"), "12104", "19.2", "uranus.png", "86832", "Uranus" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("a6eb2c70-3b9c-4ecd-b047-6f33cd194350"), "120536", "9.58", "saturn.png", "568460", "Saturn" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("9726964e-4d9a-42c4-abff-866d44a9f8ba"), "6779", "1.52", "mars.png", "642", "Mars" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("10708304-4db5-4d98-966f-0427476720ba"), "12756", "1", "earth.png", "5974", "Earth" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("6da3edb0-7e29-4b9e-bf53-0982eb513bad"), "12104", "0.722", "venus.png", "4868", "Venus" });

            migrationBuilder.InsertData(
                table: "PlanetsDb",
                columns: new[] { "Id", "Diameter", "DistanceFromSun", "Image", "Mass", "Name" },
                values: new object[] { new Guid("ad3781f2-450a-4bd2-a586-07cc9e5123b2"), "4879", "0.387", "mercury.png", "330", "Mercury" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthenticationDb");

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("10708304-4db5-4d98-966f-0427476720ba"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("289db1a3-e6d5-464e-bbfc-b0a614a100ef"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("487a60b1-c908-416f-8ac3-c2448acbc9db"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("6da3edb0-7e29-4b9e-bf53-0982eb513bad"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("844bd9a7-6ad2-45d8-8efc-19794c99e89f"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("9726964e-4d9a-42c4-abff-866d44a9f8ba"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("a6eb2c70-3b9c-4ecd-b047-6f33cd194350"));

            migrationBuilder.DeleteData(
                table: "PlanetsDb",
                keyColumn: "Id",
                keyValue: new Guid("ad3781f2-450a-4bd2-a586-07cc9e5123b2"));

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
    }
}
