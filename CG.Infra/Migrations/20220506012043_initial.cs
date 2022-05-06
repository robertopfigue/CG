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
                name: "Curriculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
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
                    CurriculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_Curriculo_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculo",
                        principalColumn: "Id");
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
                    CurriculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiencia_Curriculo_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Habilidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CurriculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habilidade_Curriculo_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CurriculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Idioma_Curriculo_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DadosPessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurriculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosPessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadosPessoa_Curriculo_CurriculoId",
                        column: x => x.CurriculoId,
                        principalTable: "Curriculo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DadosPessoa_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_CurriculoId",
                table: "Curso",
                column: "CurriculoId");

            migrationBuilder.CreateIndex(
                name: "IX_DadosPessoa_CurriculoId",
                table: "DadosPessoa",
                column: "CurriculoId");

            migrationBuilder.CreateIndex(
                name: "IX_DadosPessoa_EnderecoId",
                table: "DadosPessoa",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiencia_CurriculoId",
                table: "Experiencia",
                column: "CurriculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Habilidade_CurriculoId",
                table: "Habilidade",
                column: "CurriculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Idioma_CurriculoId",
                table: "Idioma",
                column: "CurriculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "DadosPessoa");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Curriculo");
        }
    }
}
