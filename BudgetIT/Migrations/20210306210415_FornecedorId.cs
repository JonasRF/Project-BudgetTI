using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetIT.Migrations
{
    public partial class FornecedorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscalProduto_Fornecedor_FornecedorId",
                table: "NotaFiscalProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscalServico_Fornecedor_FornecedorId",
                table: "NotaFiscalServico");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "NotaFiscalServico",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "NotaFiscalProduto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscalProduto_Fornecedor_FornecedorId",
                table: "NotaFiscalProduto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscalServico_Fornecedor_FornecedorId",
                table: "NotaFiscalServico",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscalProduto_Fornecedor_FornecedorId",
                table: "NotaFiscalProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscalServico_Fornecedor_FornecedorId",
                table: "NotaFiscalServico");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "NotaFiscalServico",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "NotaFiscalProduto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscalProduto_Fornecedor_FornecedorId",
                table: "NotaFiscalProduto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscalServico_Fornecedor_FornecedorId",
                table: "NotaFiscalServico",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
