﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetIT.Migrations
{
    public partial class OthersEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "NotaFiscalProduto",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "NotaFiscalProduto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    InscEstatudal = table.Column<string>(nullable: true),
                    InscMunicipal = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: false),
                    ServicoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    InscEstatudal = table.Column<string>(nullable: true),
                    InscMunicipal = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: false),
                    Filial = table.Column<string>(nullable: true),
                    FornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FornecedorServico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FornecedorId = table.Column<int>(nullable: false),
                    ServicoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FornecedorServico_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FornecedorServico_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscalServico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Emissao = table.Column<DateTime>(nullable: false),
                    Vencimento = table.Column<DateTime>(nullable: false),
                    NrNota = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    Oc = table.Column<string>(nullable: true),
                    FornecedorId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscalServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaFiscalServico_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteFornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    FornecdorId = table.Column<int>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteFornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClienteFornecedor_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteFornecedor_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscalProduto_FornecedorId",
                table: "NotaFiscalProduto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_FornecedorId",
                table: "Cliente",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteFornecedor_ClienteId",
                table: "ClienteFornecedor",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteFornecedor_FornecedorId",
                table: "ClienteFornecedor",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_ServicoId",
                table: "Fornecedor",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorServico_FornecedorId",
                table: "FornecedorServico",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorServico_ServicoId",
                table: "FornecedorServico",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscalServico_FornecedorId",
                table: "NotaFiscalServico",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscalProduto_Fornecedor_FornecedorId",
                table: "NotaFiscalProduto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscalProduto_Fornecedor_FornecedorId",
                table: "NotaFiscalProduto");

            migrationBuilder.DropTable(
                name: "ClienteFornecedor");

            migrationBuilder.DropTable(
                name: "FornecedorServico");

            migrationBuilder.DropTable(
                name: "NotaFiscalServico");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_NotaFiscalProduto_FornecedorId",
                table: "NotaFiscalProduto");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "NotaFiscalProduto");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "NotaFiscalProduto");
        }
    }
}
