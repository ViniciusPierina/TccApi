using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ContratoId",
                table: "Usuarios",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Especialidades",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ContratoId",
                table: "Usuarios",
                column: "ContratoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Contratos_ContratoId",
                table: "Usuarios",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Contratos_ContratoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ContratoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ContratoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Especialidades");
        }
    }
}
