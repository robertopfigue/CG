using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CG.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadosPessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosPessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Instituicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DadosPessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_DadosPessoa_DadosPessoaId",
                        column: x => x.DadosPessoaId,
                        principalTable: "DadosPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Atividades = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Atual = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DadosPessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiencia_DadosPessoa_DadosPessoaId",
                        column: x => x.DadosPessoaId,
                        principalTable: "DadosPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habilidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DadosPessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habilidade_DadosPessoa_DadosPessoaId",
                        column: x => x.DadosPessoaId,
                        principalTable: "DadosPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DadosPessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Idioma_DadosPessoa_DadosPessoaId",
                        column: x => x.DadosPessoaId,
                        principalTable: "DadosPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_DadosPessoaId",
                table: "Curso",
                column: "DadosPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiencia_DadosPessoaId",
                table: "Experiencia",
                column: "DadosPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Habilidade_DadosPessoaId",
                table: "Habilidade",
                column: "DadosPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Idioma_DadosPessoaId",
                table: "Idioma",
                column: "DadosPessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "DadosPessoa");
        }
    }
}
