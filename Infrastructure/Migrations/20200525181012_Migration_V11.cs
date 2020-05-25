using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guias_ContratoId",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "GuiaId",
                table: "Contratos");

            migrationBuilder.CreateIndex(
                name: "IX_Guias_ContratoId",
                table: "Guias",
                column: "ContratoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guias_ContratoId",
                table: "Guias");

            migrationBuilder.AddColumn<Guid>(
                name: "GuiaId",
                table: "Contratos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Guias_ContratoId",
                table: "Guias",
                column: "ContratoId",
                unique: true);
        }
    }
}
