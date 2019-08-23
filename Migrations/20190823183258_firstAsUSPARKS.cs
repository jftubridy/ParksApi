using Microsoft.EntityFrameworkCore.Migrations;

namespace USPark.Migrations
{
    public partial class firstAsUSPARKS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Species",
                table: "parks",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "parks",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "parks",
                newName: "Species");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "parks",
                newName: "Gender");
        }
    }
}
