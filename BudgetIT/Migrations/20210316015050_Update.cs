﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetIT.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Filial = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
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
                    Telefone = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClienteFornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscalProduto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Emissao = table.Column<DateTime>(nullable: false),
                    Vencimento = table.Column<DateTime>(nullable: false),
                    NrNota = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    Oc = table.Column<string>(nullable: true),
                    FornecedorId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscalProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaFiscalProduto_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
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
                    FornecedorId = table.Column<int>(nullable: false),
                    Notas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscalServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaFiscalServico_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    FornecedorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servico_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteFornecedor_ClienteId",
                table: "ClienteFornecedor",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteFornecedor_FornecedorId",
                table: "ClienteFornecedor",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscalProduto_FornecedorId",
                table: "NotaFiscalProduto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscalServico_FornecedorId",
                table: "NotaFiscalServico",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_FornecedorId",
                table: "Servico",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteFornecedor");

            migrationBuilder.DropTable(
                name: "NotaFiscalProduto");

            migrationBuilder.DropTable(
                name: "NotaFiscalServico");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
