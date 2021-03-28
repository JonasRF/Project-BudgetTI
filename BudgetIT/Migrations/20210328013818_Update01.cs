using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetIT.Migrations
{
    public partial class Update01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notas",
                table: "NotaFiscalServico");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "NotaFiscalServico",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "NotaFiscalServico");

            migrationBuilder.AddColumn<int>(
                name: "Notas",
                table: "NotaFiscalServico",
                nullable: false,
                defaultValue: 0);
        }
    }
}
