using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevCitySim.Migrations
{
    /// <inheritdoc />
    public partial class Citizen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "moedernaam",
                table: "Citizens",
                newName: "Job");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Job",
                table: "Citizens",
                newName: "moedernaam");
        }
    }
}
