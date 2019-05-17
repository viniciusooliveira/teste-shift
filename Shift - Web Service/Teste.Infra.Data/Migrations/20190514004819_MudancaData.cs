using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Infra.Data.Migrations
{
    public partial class MudancaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "OrdemServico",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 13, 21, 48, 19, 262, DateTimeKind.Local).AddTicks(7738),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 13, 21, 46, 39, 555, DateTimeKind.Local).AddTicks(8640));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "OrdemServico",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 13, 21, 46, 39, 555, DateTimeKind.Local).AddTicks(8640),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 5, 13, 21, 48, 19, 262, DateTimeKind.Local).AddTicks(7738));
        }
    }
}
