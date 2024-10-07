using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevCitySim.Migrations
{
    /// <inheritdoc />
    public partial class aanpassingcitizen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Job",
                table: "Citizens",
                newName: "moedernaam");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "moedernaam",
                table: "Citizens",
                newName: "Job");
        }
    }
}
