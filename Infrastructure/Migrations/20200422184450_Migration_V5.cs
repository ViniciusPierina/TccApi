using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodUsu",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codprest",
                table: "Medicos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codespec",
                table: "Especialidades",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codtit",
                table: "Contratos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CodUsu",
                table: "Usuarios",
                column: "CodUsu",
                unique: true,
                filter: "[CodUsu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_Codprest",
                table: "Medicos",
                column: "Codprest",
                unique: true,
                filter: "[Codprest] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Guias_CodPaciente_CodEspecMedico_CodProcedimento",
                table: "Guias",
                columns: new[] { "CodPaciente", "CodEspecMedico", "CodProcedimento" })
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_Codespec",
                table: "Especialidades",
                column: "Codespec",
                unique: true,
                filter: "[Codespec] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_Codtit",
                table: "Contratos",
                column: "Codtit",
                unique: true,
                filter: "[Codtit] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_DataConsulta_CodMedico",
                table: "Agendamentos",
                columns: new[] { "DataConsulta", "CodMedico" })
                .Annotation("SqlServer:Clustered", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CodUsu",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_Codprest",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Guias_CodPaciente_CodEspecMedico_CodProcedimento",
                table: "Guias");

            migrationBuilder.DropIndex(
                name: "IX_Especialidades_Codespec",
                table: "Especialidades");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_Codtit",
                table: "Contratos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_DataConsulta_CodMedico",
                table: "Agendamentos");

            migrationBuilder.AlterColumn<string>(
                name: "CodUsu",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codprest",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codespec",
                table: "Especialidades",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codtit",
                table: "Contratos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
