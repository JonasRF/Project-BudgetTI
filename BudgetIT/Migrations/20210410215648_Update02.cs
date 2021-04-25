using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetIT.Migrations
{
    public partial class Update02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FornecedorId = table.Column<int>(nullable: true),
                    ServicoId = table.Column<int>(nullable: true),
                    NotaFiscalProdutoId = table.Column<int>(nullable: true),
                    NotaFiscalServicoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetRecord_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BudgetRecord_NotaFiscalProduto_NotaFiscalProdutoId",
                        column: x => x.NotaFiscalProdutoId,
                        principalTable: "NotaFiscalProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BudgetRecord_NotaFiscalServico_NotaFiscalServicoId",
                        column: x => x.NotaFiscalServicoId,
                        principalTable: "NotaFiscalServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BudgetRecord_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetRecord_FornecedorId",
                table: "BudgetRecord",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetRecord_NotaFiscalProdutoId",
                table: "BudgetRecord",
                column: "NotaFiscalProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetRecord_NotaFiscalServicoId",
                table: "BudgetRecord",
                column: "NotaFiscalServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetRecord_ServicoId",
                table: "BudgetRecord",
                column: "ServicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetRecord");
        }
    }
}
