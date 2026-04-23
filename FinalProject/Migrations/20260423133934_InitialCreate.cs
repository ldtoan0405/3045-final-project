using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Hobbies",
                columns: new[] { "Id", "Category", "IsIndoor", "Name", "SkillLevel" },
                values: new object[,]
                {
                    { 1, "Arts", false, "Photography", 7 },
                    { 2, "Technology", true, "Coding", 9 },
                    { 3, "Games", true, "Chess", 5 },
                    { 4, "Outdoors", false, "Hiking", 8 },
                    { 5, "Culinary", true, "Cooking", 6 }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2004, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mathematics", "Duc Toan Le", "Junior" },
                    { 2, new DateTime(1999, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jane Doe", "Senior" },
                    { 3, new DateTime(2001, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Math", "Bob Smith", "Sophomore" },
                    { 4, new DateTime(2002, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Physics", "Alice Wong", "Freshman" },
                    { 5, new DateTime(2000, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Statistics", "Charlie Brown", "Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
