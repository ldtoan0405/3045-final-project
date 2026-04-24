using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedRemainingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreakfastFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainIngredient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakfastFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteCities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    HasMajorAirport = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteCities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BreakfastFoods",
                columns: new[] { "Id", "Calories", "IsVegetarian", "MainIngredient", "Name" },
                values: new object[,]
                {
                    { 1, 350, true, "Flour", "Pancakes" },
                    { 2, 250, true, "Eggs", "Omelet" },
                    { 3, 450, false, "Bacon", "Bacon & Eggs" },
                    { 4, 150, true, "Milk", "Greek Yogurt" },
                    { 5, 600, false, "Tortilla", "Breakfast Burrito" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteCities",
                columns: new[] { "Id", "HasMajorAirport", "Name", "Population", "State" },
                values: new object[,]
                {
                    { 1, true, "Cincinnati", 309000, "Ohio" },
                    { 2, true, "Nashville", 689000, "Tennessee" },
                    { 3, false, "Boulder", 108000, "Colorado" },
                    { 4, true, "Savannah", 147000, "Georgia" },
                    { 5, false, "Asheville", 94000, "North Carolina" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreakfastFoods");

            migrationBuilder.DropTable(
                name: "FavoriteCities");
        }
    }
}
