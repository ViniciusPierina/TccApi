﻿// <auto-generated />
using System;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ConfigurationContext))]
    [Migration("20200421204821_Migration_V2")]
    partial class Migration_V2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Agendamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CodMedico")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("HoraConsulta")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MedicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Domain.Models.Contrato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codtit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpftit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nometit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situcont")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cadcont");
                });

            modelBuilder.Entity("Domain.Models.Especialidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codespec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Descespec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cadespec");
                });

            modelBuilder.Entity("Domain.Models.Guia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CodEspecMedico")
                        .HasColumnType("int");

                    b.Property<long>("CodGuia")
                        .HasColumnType("bigint");

                    b.Property<int>("CodPaciente")
                        .HasColumnType("int");

                    b.Property<int>("CodPrestExecutante")
                        .HasColumnType("int");

                    b.Property<int>("CodPrestSolicitante")
                        .HasColumnType("int");

                    b.Property<int>("CodProcedimento")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("HoraAgendamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraEmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomePaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCons")
                        .HasColumnType("int");

                    b.Property<int>("TipoGuia")
                        .HasColumnType("int");

                    b.Property<float>("ValorConsulta")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("cadguia");
                });

            modelBuilder.Entity("Domain.Models.Medico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Baiprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codesp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conselho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Crmprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Endprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EspecialidadeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Foneprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nomeprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rede")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Status")
                        .HasColumnType("bigint");

                    b.Property<string>("Tipoprest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("cadprest");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodUsu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situusu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cadusu");
                });

            modelBuilder.Entity("Domain.Models.Agendamento", b =>
                {
                    b.HasOne("Domain.Models.Medico", "Medico")
                        .WithMany("Agendamentos")
                        .HasForeignKey("MedicoId");
                });

            modelBuilder.Entity("Domain.Models.Medico", b =>
                {
                    b.HasOne("Domain.Models.Especialidade", "Especialidade")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
