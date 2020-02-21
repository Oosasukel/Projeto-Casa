using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoCasaDeShow.Migrations
{
    public partial class SeDeusQuiserUltimaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClienteId",
                table: "Eventos",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "ClienteId",
                table: "CasasDeShow",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "CasasDeShow");
        }
    }
}
