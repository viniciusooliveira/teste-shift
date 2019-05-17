using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Infra.Data.Migrations
{
    public partial class AdicaoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "OrdemServico",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 13, 21, 44, 13, 415, DateTimeKind.Local).AddTicks(2012),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 13, 20, 55, 12, 257, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Descricao", "Estado" },
                values: new object[,]
                {
                    { 1, "Votuporanga", 25 },
                    { 2, "São José do Rio Preto", 25 }
                });

            migrationBuilder.InsertData(
                table: "Convenio",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Unimed" },
                    { 2, "HB Saúde" }
                });

            migrationBuilder.InsertData(
                table: "Especialidade",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Dermatologia" },
                    { 2, "Neurologia" },
                    { 3, "Pediatria" }
                });

            migrationBuilder.InsertData(
                table: "Setor",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Bioquímica" },
                    { 2, "Hematologia" }
                });

            migrationBuilder.InsertData(
                table: "Bairro",
                columns: new[] { "Id", "Descricao", "IdCidade" },
                values: new object[,]
                {
                    { 1, "Vila América", 1 },
                    { 2, "Centro", 1 },
                    { 3, "Vila Imperial", 2 },
                    { 4, "Centro", 2 }
                });

            migrationBuilder.InsertData(
                table: "Exame",
                columns: new[] { "Id", "Descricao", "IdSetor", "MaterialBiologico", "Prazo" },
                values: new object[,]
                {
                    { 1, "Exame de Glicose", 1, "Sangue", 4 },
                    { 2, "Hemograma", 2, "Sangue", 3 }
                });

            migrationBuilder.InsertData(
                table: "Medico",
                columns: new[] { "Id", "IdEspecialidade", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "Daniela Aline Aurora Costa" },
                    { 2, 2, "Francisco Eduardo Lucca Teixeira" },
                    { 3, 3, "Giovanni Matheus Santos" }
                });

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "DataNascimento", "Endereco", "IdCidade", "Nome", "Sexo" },
                values: new object[] { 1, new DateTime(1998, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Chile, 4219", 1, "Vinícius Eduardo Alves Oliveira", "Masculino" });

            migrationBuilder.InsertData(
                table: "PostoColeta",
                columns: new[] { "Id", "Descricao", "IdBairro" },
                values: new object[] { 1, "Posto de coleta 01", 1 });

            migrationBuilder.InsertData(
                table: "PrecoExame",
                columns: new[] { "Id", "IdConvenio", "IdExame", "Preco" },
                values: new object[,]
                {
                    { 1, 1, 1, 89.90m },
                    { 3, 2, 1, 99.90m },
                    { 2, 1, 2, 55.00m },
                    { 4, 2, 2, 60.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bairro",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bairro",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bairro",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medico",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medico",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medico",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostoColeta",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrecoExame",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrecoExame",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrecoExame",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrecoExame",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bairro",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Convenio",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Convenio",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Especialidade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Especialidade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Especialidade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exame",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exame",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "OrdemServico",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 13, 20, 55, 12, 257, DateTimeKind.Local).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 13, 21, 44, 13, 415, DateTimeKind.Local).AddTicks(2012));
        }
    }
}
