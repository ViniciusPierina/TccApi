using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_cadprest_MedicoId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_cadprest_cadespec_EspecialidadeId",
                table: "cadprest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cadusu",
                table: "cadusu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cadprest",
                table: "cadprest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cadguia",
                table: "cadguia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cadespec",
                table: "cadespec");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cadcont",
                table: "cadcont");

            migrationBuilder.RenameTable(
                name: "cadusu",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "cadprest",
                newName: "Medicos");

            migrationBuilder.RenameTable(
                name: "cadguia",
                newName: "Guias");

            migrationBuilder.RenameTable(
                name: "cadespec",
                newName: "Especialidades");

            migrationBuilder.RenameTable(
                name: "cadcont",
                newName: "Contratos");

            migrationBuilder.RenameIndex(
                name: "IX_cadprest_EspecialidadeId",
                table: "Medicos",
                newName: "IX_Medicos_EspecialidadeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guias",
                table: "Guias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Medicos_MedicoId",
                table: "Agendamentos",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId",
                table: "Medicos",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Medicos_MedicoId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guias",
                table: "Guias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "cadusu");

            migrationBuilder.RenameTable(
                name: "Medicos",
                newName: "cadprest");

            migrationBuilder.RenameTable(
                name: "Guias",
                newName: "cadguia");

            migrationBuilder.RenameTable(
                name: "Especialidades",
                newName: "cadespec");

            migrationBuilder.RenameTable(
                name: "Contratos",
                newName: "cadcont");

            migrationBuilder.RenameIndex(
                name: "IX_Medicos_EspecialidadeId",
                table: "cadprest",
                newName: "IX_cadprest_EspecialidadeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cadusu",
                table: "cadusu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cadprest",
                table: "cadprest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cadguia",
                table: "cadguia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cadespec",
                table: "cadespec",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cadcont",
                table: "cadcont",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_cadprest_MedicoId",
                table: "Agendamentos",
                column: "MedicoId",
                principalTable: "cadprest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cadprest_cadespec_EspecialidadeId",
                table: "cadprest",
                column: "EspecialidadeId",
                principalTable: "cadespec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
