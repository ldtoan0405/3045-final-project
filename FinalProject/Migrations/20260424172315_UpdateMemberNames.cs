using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMemberNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { new DateTime(2007, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Nate Otten", "Freshman" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { new DateTime(1999, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Jane Doe", "Senior" });
        }
    }
}
