using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Infra.Data.Migrations
{
    public partial class MudancaDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Paciente",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "OrdemServico",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 13, 21, 46, 39, 555, DateTimeKind.Local).AddTicks(8640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 13, 21, 44, 13, 415, DateTimeKind.Local).AddTicks(2012));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "OrdemServico",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 13, 21, 44, 13, 415, DateTimeKind.Local).AddTicks(2012),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 13, 21, 46, 39, 555, DateTimeKind.Local).AddTicks(8640));
        }
    }
}
