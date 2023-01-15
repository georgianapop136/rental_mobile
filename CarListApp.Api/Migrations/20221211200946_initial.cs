﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarListApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Model", "Year" },
                values: new object[,]
                {
                    { 1, "Honda", "Fit", "ABC" },
                    { 2, "Honda", "Civic", "ABC2" },
                    { 3, "Honda", "Stream", "ABC1" },
                    { 4, "Nissan", "Note", "ABC4" },
                    { 5, "Nissan", "Atlas", "ABC5" },
                    { 6, "Nissan", "Dualis", "ABC6" },
                    { 7, "Nissan", "Murano", "ABC7" },
                    { 8, "Audi", "A5", "ABC8" },
                    { 9, "BMW", "M3", "ABC9" },
                    { 10, "Jaguar", "F-Pace", "ABC10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
