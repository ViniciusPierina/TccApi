using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cadprest_cadespec_EspecialidadeId",
                table: "cadprest");

            migrationBuilder.AlterColumn<Guid>(
                name: "EspecialidadeId",
                table: "cadprest",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_cadprest_cadespec_EspecialidadeId",
                table: "cadprest",
                column: "EspecialidadeId",
                principalTable: "cadespec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cadprest_cadespec_EspecialidadeId",
                table: "cadprest");

            migrationBuilder.AlterColumn<Guid>(
                name: "EspecialidadeId",
                table: "cadprest",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_cadprest_cadespec_EspecialidadeId",
                table: "cadprest",
                column: "EspecialidadeId",
                principalTable: "cadespec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
