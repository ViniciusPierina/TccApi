using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Migration_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cadcont",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Codtit = table.Column<string>(nullable: true),
                    Nometit = table.Column<string>(nullable: true),
                    Situcont = table.Column<string>(nullable: true),
                    Cpftit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadcont", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cadespec",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Codespec = table.Column<string>(nullable: true),
                    Descespec = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadespec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cadguia",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CodGuia = table.Column<long>(nullable: false),
                    TipoCons = table.Column<int>(nullable: false),
                    CodPaciente = table.Column<int>(nullable: false),
                    NomePaciente = table.Column<string>(nullable: true),
                    CodPrestSolicitante = table.Column<int>(nullable: false),
                    CodPrestExecutante = table.Column<int>(nullable: false),
                    CodEspecMedico = table.Column<int>(nullable: false),
                    TipoGuia = table.Column<int>(nullable: false),
                    DataEmissao = table.Column<DateTime>(nullable: false),
                    HoraEmissao = table.Column<DateTime>(nullable: false),
                    DataAgendamento = table.Column<DateTime>(nullable: false),
                    HoraAgendamento = table.Column<DateTime>(nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    HoraVencimento = table.Column<DateTime>(nullable: false),
                    CodProcedimento = table.Column<int>(nullable: false),
                    ValorConsulta = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadguia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cadusu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CodUsu = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Situusu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadusu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cadprest",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Codprest = table.Column<string>(nullable: true),
                    Nomeprest = table.Column<string>(nullable: true),
                    Tipoprest = table.Column<string>(nullable: true),
                    Endprest = table.Column<string>(nullable: true),
                    Baiprest = table.Column<string>(nullable: true),
                    Cidprest = table.Column<string>(nullable: true),
                    Categprest = table.Column<string>(nullable: true),
                    Foneprest = table.Column<string>(nullable: true),
                    Codesp = table.Column<string>(nullable: true),
                    Status = table.Column<long>(nullable: false),
                    Conselho = table.Column<string>(nullable: true),
                    Rede = table.Column<string>(nullable: true),
                    Crmprest = table.Column<string>(nullable: true),
                    EspecialidadeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadprest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cadprest_cadespec_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "cadespec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Codigo = table.Column<int>(nullable: false),
                    CodMedico = table.Column<int>(nullable: false),
                    DataConsulta = table.Column<DateTime>(nullable: false),
                    HoraConsulta = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    MedicoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamentos_cadprest_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "cadprest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_MedicoId",
                table: "Agendamentos",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_cadprest_EspecialidadeId",
                table: "cadprest",
                column: "EspecialidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "cadcont");

            migrationBuilder.DropTable(
                name: "cadguia");

            migrationBuilder.DropTable(
                name: "cadusu");

            migrationBuilder.DropTable(
                name: "cadprest");

            migrationBuilder.DropTable(
                name: "cadespec");
        }
    }
}
