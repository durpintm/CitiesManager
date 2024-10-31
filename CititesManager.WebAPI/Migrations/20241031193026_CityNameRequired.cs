using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CititesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CityNameRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5831fa7b-5d8e-4627-abb1-bcff99bbaa20"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("fd45a30a-c6a9-48ec-8168-2b1337394767"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[,]
                {
                    { new Guid("4d80a83a-4004-47cf-ad1e-9dcdcdd7f6ab"), "Dallas" },
                    { new Guid("af5149a9-7acf-4302-a990-31983481a0c5"), "Toronto" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("4d80a83a-4004-47cf-ad1e-9dcdcdd7f6ab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("af5149a9-7acf-4302-a990-31983481a0c5"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[,]
                {
                    { new Guid("5831fa7b-5d8e-4627-abb1-bcff99bbaa20"), "Toronto" },
                    { new Guid("fd45a30a-c6a9-48ec-8168-2b1337394767"), "Dallas" }
                });
        }
    }
}
