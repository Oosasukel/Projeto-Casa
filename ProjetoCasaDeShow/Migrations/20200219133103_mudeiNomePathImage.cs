using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoCasaDeShow.Migrations
{
    public partial class mudeiNomePathImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pathImage",
                table: "Eventos",
                newName: "PathImage");

            migrationBuilder.RenameColumn(
                name: "pathImage",
                table: "CasasDeShow",
                newName: "PathImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PathImage",
                table: "Eventos",
                newName: "pathImage");

            migrationBuilder.RenameColumn(
                name: "PathImage",
                table: "CasasDeShow",
                newName: "pathImage");
        }
    }
}
