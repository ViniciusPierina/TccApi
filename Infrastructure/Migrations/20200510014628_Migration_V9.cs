using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guias_CodPaciente_CodEspecMedico_CodProcedimento",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "CodEspecMedico",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "CodPaciente",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "CodPrestExecutante",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "CodPrestSolicitante",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "CodProcedimento",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "DataAgendamento",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "DataEmissao",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "HoraAgendamento",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "HoraEmissao",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "HoraVencimento",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "NomePaciente",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "TipoGuia",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "ValorConsulta",
                table: "Guias");

            migrationBuilder.AlterColumn<string>(
                name: "TipoCons",
                table: "Guias",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CodAtend",
                table: "Guias",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEmi",
                table: "Guias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Hora",
                table: "Guias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Origem",
                table: "Guias",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Guias",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidGuia",
                table: "Guias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Guias_CodGuia",
                table: "Guias",
                column: "CodGuia",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guias_CodGuia",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "CodAtend",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "DataEmi",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "Origem",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "ValidGuia",
                table: "Guias");

            migrationBuilder.AlterColumn<int>(
                name: "TipoCons",
                table: "Guias",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodEspecMedico",
                table: "Guias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodPaciente",
                table: "Guias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodPrestExecutante",
                table: "Guias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodPrestSolicitante",
                table: "Guias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodProcedimento",
                table: "Guias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAgendamento",
                table: "Guias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEmissao",
                table: "Guias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "Guias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraAgendamento",
                table: "Guias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraEmissao",
                table: "Guias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraVencimento",
                table: "Guias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NomePaciente",
                table: "Guias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoGuia",
                table: "Guias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ValorConsulta",
                table: "Guias",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_Guias_CodPaciente_CodEspecMedico_CodProcedimento",
                table: "Guias",
                columns: new[] { "CodPaciente", "CodEspecMedico", "CodProcedimento" })
                .Annotation("SqlServer:Clustered", false);
        }
    }
}
