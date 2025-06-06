using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Calorie_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Calorie = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Fats = table.Column<decimal>(type: "numeric", nullable: true),
                    Salts = table.Column<decimal>(type: "numeric", nullable: true),
                    Protein = table.Column<decimal>(type: "numeric", nullable: true),
                    Caffeine = table.Column<decimal>(type: "numeric", nullable: true),
                    GramsInPortion = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateTime = table.Column<DateTime>(type: "date", nullable: false),
                    Grams = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Portions = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    FoodId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateTime = table.Column<DateTime>(type: "date", nullable: false),
                    Noted = table.Column<string>(type: "character varying(514)", maxLength: 514, nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Caffeine", "Calorie", "Fats", "GramsInPortion", "Name", "Protein", "Salts" },
                values: new object[,]
                {
                    { 1, null, 300m, 13.4m, 132m, "Pizza", 10m, 14m },
                    { 2, null, 225m, 16.4m, 140m, "Spaghetti", 20m, 18m },
                    { 3, null, 165m, 3.6m, 100m, "Chicken Breast", 31m, 0.7m },
                    { 4, null, 90m, 0.2m, 150m, "Apple", 0.3m, 0m },
                    { 5, null, 100m, 0.3m, 120m, "Banana", 1.1m, 0m },
                    { 6, null, 120m, 0.6m, 100m, "Broccoli", 3.7m, 0.05m },
                    { 7, null, 208m, 13m, 100m, "Salmon", 20m, 0.1m },
                    { 8, null, 90m, 15m, 100m, "Avocado", 2m, 0.01m },
                    { 9, null, 200m, 0.3m, 100m, "Rice", 2.7m, 0m },
                    { 10, null, 303m, 14m, 120m, "Cheeseburger", 17m, 1.2m },
                    { 11, null, 312m, 15m, 100m, "French Fries", 3.4m, 0.6m },
                    { 12, null, 90m, 0.1m, 130m, "Orange", 0.9m, 0m },
                    { 13, null, 155m, 11m, 60m, "Egg", 13m, 0.1m },
                    { 14, null, 42m, 1m, 100m, "Milk", 3.4m, 0.05m },
                    { 15, null, 59m, 0.4m, 150m, "Yogurt", 10m, 0.1m },
                    { 16, null, 588m, 50m, 100m, "Peanut Butter", 25m, 1.2m },
                    { 17, null, 579m, 49m, 100m, "Almonds", 21m, 0m },
                    { 18, null, 68m, 1.4m, 40m, "Oatmeal", 2.4m, 0m },
                    { 19, 5m, 1m, 0m, 250m, "Tea", 0m, 0m },
                    { 20, 25m, 2m, 0m, 250m, "Coffee", 0.3m, 0m },
                    { 21, 100m, 0m, 0m, 10000m, "Brain Implosion Energy Drink", 0m, 0m }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "DateTime", "FoodId", "Noted" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Skipped breakfast" },
                    { 7, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Felt energetic after lunch" },
                    { 8, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Meal timing was off" },
                    { 9, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Try more vegetarian meals next week" },
                    { 10, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Late dinner caused bloating" }
                });

            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "Id", "DateTime", "FoodId", "Grams", "Portions" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Utc), 20, 181.6m, 3.1m },
                    { 2, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc), 18, 289.6m, 2.1m },
                    { 3, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), 11, 391.6m, 3.1m },
                    { 4, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Utc), 6, 277.2m, 1.1m },
                    { 5, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc), 14, 163.3m, 2.8m },
                    { 6, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Utc), 11, 242.7m, 2.1m },
                    { 7, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc), 3, 366.1m, 0.6m },
                    { 8, new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Utc), 11, 121.1m, 3.2m },
                    { 9, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Utc), 18, 260.1m, 1.5m },
                    { 10, new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Utc), 14, 196.3m, 3.2m },
                    { 11, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), 13, 117.9m, 1.1m },
                    { 12, new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Utc), 10, 303.0m, 3.0m },
                    { 13, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Utc), 9, 329.5m, 2.7m },
                    { 14, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), 9, 299.3m, 2.0m },
                    { 15, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), 19, 262.1m, 1.2m },
                    { 16, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Utc), 9, 343.3m, 0.5m },
                    { 17, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Utc), 6, 299.7m, 1.2m },
                    { 18, new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Utc), 17, 127.9m, 1.8m },
                    { 19, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Utc), 14, 168.3m, 2.2m },
                    { 20, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Utc), 8, 326.9m, 2.7m },
                    { 21, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), 14, 77.4m, 2.8m },
                    { 22, new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc), 18, 378.5m, 2.2m },
                    { 23, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Utc), 2, 236.6m, 0.7m },
                    { 24, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), 19, 205.0m, 1.3m },
                    { 25, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Utc), 3, 178.2m, 1.9m },
                    { 26, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Utc), 15, 185.4m, 2.0m },
                    { 27, new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Utc), 12, 196.3m, 1.9m },
                    { 28, new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Utc), 18, 372.0m, 1.2m },
                    { 29, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Utc), 6, 319.7m, 1.7m },
                    { 30, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), 3, 51.0m, 1.8m },
                    { 31, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Utc), 20, 324.6m, 2.8m },
                    { 32, new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Utc), 9, 398.8m, 2.6m },
                    { 33, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), 5, 336.8m, 1.8m },
                    { 34, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Utc), 2, 397.5m, 1.2m },
                    { 35, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Utc), 5, 342.9m, 0.9m },
                    { 36, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), 1, 370.7m, 2.0m },
                    { 37, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), 6, 121.8m, 3.1m },
                    { 38, new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Utc), 3, 219.5m, 1.9m },
                    { 39, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc), 5, 98.6m, 2.0m },
                    { 40, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), 5, 275.0m, 2.5m },
                    { 41, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc), 8, 384.1m, 0.5m },
                    { 42, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), 4, 301.1m, 3.3m },
                    { 43, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Utc), 12, 135.6m, 3.1m },
                    { 44, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Utc), 10, 102.7m, 1.2m },
                    { 45, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), 17, 138.2m, 1.7m },
                    { 46, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Utc), 9, 386.8m, 2.3m },
                    { 47, new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Utc), 11, 297.0m, 1.2m },
                    { 48, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Utc), 15, 177.7m, 2.7m },
                    { 49, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), 15, 371.6m, 2.7m },
                    { 50, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc), 17, 384.2m, 2.1m }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "DateTime", "FoodId", "Noted" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Leftover pizza" },
                    { 2, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Too salty, reduce portion next time" },
                    { 3, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Tried grilled tofu, decent protein source" },
                    { 4, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Had too much chocolate" },
                    { 5, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Coffee gave slight jitters, reduce caffeine?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_History_FoodId",
                table: "History",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_FoodId",
                table: "Notes",
                column: "FoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
