using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Infra.Data.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Convenio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bairro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    IdCidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bairro_Cidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    IdCidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paciente_Cidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    IdEspecialidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_IdEspecialidade",
                        column: x => x.IdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    IdSetor = table.Column<int>(nullable: false),
                    MaterialBiologico = table.Column<string>(nullable: false),
                    Prazo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exame_Setor_IdSetor",
                        column: x => x.IdSetor,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostoColeta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    IdBairro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostoColeta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostoColeta_Bairro_IdBairro",
                        column: x => x.IdBairro,
                        principalTable: "Bairro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrecoExame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdConvenio = table.Column<int>(nullable: false),
                    IdExame = table.Column<int>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrecoExame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrecoExame_Convenio_IdConvenio",
                        column: x => x.IdConvenio,
                        principalTable: "Convenio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrecoExame_Exame_IdExame",
                        column: x => x.IdExame,
                        principalTable: "Exame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 5, 13, 20, 55, 12, 257, DateTimeKind.Local).AddTicks(9612)),
                    IdPaciente = table.Column<int>(nullable: false),
                    IdConvenio = table.Column<int>(nullable: false),
                    IdPostoColeta = table.Column<int>(nullable: false),
                    IdMedico = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Convenio_IdConvenio",
                        column: x => x.IdConvenio,
                        principalTable: "Convenio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemServico_PostoColeta_IdPostoColeta",
                        column: x => x.IdPostoColeta,
                        principalTable: "PostoColeta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServicoExame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOrdemServico = table.Column<int>(nullable: false),
                    IdExame = table.Column<int>(nullable: false),
                    EntregaResultado = table.Column<TimeSpan>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServicoExame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServicoExame_Exame_IdExame",
                        column: x => x.IdExame,
                        principalTable: "Exame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemServicoExame_OrdemServico_IdOrdemServico",
                        column: x => x.IdOrdemServico,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bairro_IdCidade",
                table: "Bairro",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Exame_IdSetor",
                table: "Exame",
                column: "IdSetor");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdEspecialidade",
                table: "Medico",
                column: "IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_IdConvenio",
                table: "OrdemServico",
                column: "IdConvenio");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_IdMedico",
                table: "OrdemServico",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_IdPaciente",
                table: "OrdemServico",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_IdPostoColeta",
                table: "OrdemServico",
                column: "IdPostoColeta");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServicoExame_IdExame",
                table: "OrdemServicoExame",
                column: "IdExame");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServicoExame_IdOrdemServico",
                table: "OrdemServicoExame",
                column: "IdOrdemServico");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdCidade",
                table: "Paciente",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_PostoColeta_IdBairro",
                table: "PostoColeta",
                column: "IdBairro");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoExame_IdConvenio",
                table: "PrecoExame",
                column: "IdConvenio");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoExame_IdExame",
                table: "PrecoExame",
                column: "IdExame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdemServicoExame");

            migrationBuilder.DropTable(
                name: "PrecoExame");

            migrationBuilder.DropTable(
                name: "OrdemServico");

            migrationBuilder.DropTable(
                name: "Exame");

            migrationBuilder.DropTable(
                name: "Convenio");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "PostoColeta");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Bairro");

            migrationBuilder.DropTable(
                name: "Cidade");
        }
    }
}
