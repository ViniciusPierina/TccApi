using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GuiaId",
                table: "Medicos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ContratoId",
                table: "Guias",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MedicoId",
                table: "Guias",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GuiaId",
                table: "Contratos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Guias_ContratoId",
                table: "Guias",
                column: "ContratoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guias_MedicoId",
                table: "Guias",
                column: "MedicoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Guias_Contratos_ContratoId",
                table: "Guias",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guias_Medicos_MedicoId",
                table: "Guias",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guias_Contratos_ContratoId",
                table: "Guias");

            migrationBuilder.DropForeignKey(
                name: "FK_Guias_Medicos_MedicoId",
                table: "Guias");

            migrationBuilder.DropIndex(
                name: "IX_Guias_ContratoId",
                table: "Guias");

            migrationBuilder.DropIndex(
                name: "IX_Guias_MedicoId",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "GuiaId",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "ContratoId",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "GuiaId",
                table: "Contratos");
        }
    }
}
