using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetIT.Migrations
{
    public partial class OthersEntities02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteFornecedor_Fornecedor_FornecedorId",
                table: "ClienteFornecedor");

            migrationBuilder.DropColumn(
                name: "FornecdorId",
                table: "ClienteFornecedor");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "ClienteFornecedor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteFornecedor_Fornecedor_FornecedorId",
                table: "ClienteFornecedor",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteFornecedor_Fornecedor_FornecedorId",
                table: "ClienteFornecedor");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "ClienteFornecedor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FornecdorId",
                table: "ClienteFornecedor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteFornecedor_Fornecedor_FornecedorId",
                table: "ClienteFornecedor",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
