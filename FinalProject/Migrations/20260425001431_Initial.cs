using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillLevel = table.Column<int>(type: "int", nullable: false),
                    IsIndoor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BreakfastFoods",
                columns: new[] { "Id", "Calories", "IsVegetarian", "MainIngredient", "Name" },
                values: new object[,]
                {
                    { 1, 350, false, "Pork", "Sausage" },
                    { 2, 250, true, "Flour", "Waffle" },
                    { 3, 450, false, "Pork", "Bacon" },
                    { 4, 150, true, "Oats", "Cereal" },
                    { 5, 300, true, "Eggs", "Omelette" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteCities",
                columns: new[] { "Id", "HasMajorAirport", "Name", "Population", "State" },
                values: new object[,]
                {
                    { 1, true, "Cincinnati", 309000, "Ohio" },
                    { 2, true, "Atlanta", 498000, "Georgia" },
                    { 3, true, "Columbus", 921000, "Ohio" },
                    { 4, false, "Dayton", 137000, "Ohio" },
                    { 5, true, "Charlotte", 897000, "North Carolina" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Category", "IsIndoor", "Name", "SkillLevel" },
                values: new object[,]
                {
                    { 1, "Arts", false, "Videography", 7 },
                    { 2, "Technology", true, "Coding", 9 },
                    { 3, "Outdoors", false, "rock Climbing", 8 },
                    { 4, "Sports", true, "Basketball", 8 },
                    { 5, "Fitness", true, "Running", 6 }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2004, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mathematics", "Duc Toan Le", "Junior" },
                    { 2, new DateTime(2007, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Nate Otten", "Freshman" },
                    { 3, new DateTime(1946, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business Administration", "Jimmy Buffett", "Senior" },
                    { 4, new DateTime(1948, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kinesiology", "Carl Weathers", "Junior" },
                    { 5, new DateTime(1732, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Political Science", "George Washington", "Senior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreakfastFoods");

            migrationBuilder.DropTable(
                name: "FavoriteCities");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
