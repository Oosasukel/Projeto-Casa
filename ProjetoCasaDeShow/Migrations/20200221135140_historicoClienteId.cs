using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoCasaDeShow.Migrations
{
    public partial class historicoClienteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClienteId",
                table: "Historicos",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Historicos");
        }
    }
}
