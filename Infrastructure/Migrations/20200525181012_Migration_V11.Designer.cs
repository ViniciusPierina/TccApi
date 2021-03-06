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
    [Migration("20200525181012_Migration_V11")]
    partial class Migration_V11
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

                    b.Property<Guid>("MedicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("DataConsulta", "CodMedico")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Domain.Models.Contrato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codtit")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("Codtit")
                        .IsUnique()
                        .HasFilter("[Codtit] IS NOT NULL");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("Domain.Models.Especialidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codespec")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Descespec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Codespec")
                        .IsUnique()
                        .HasFilter("[Codespec] IS NOT NULL");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Domain.Models.Guia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodAtend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CodGuia")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ContratoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MedicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Origem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidGuia")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CodGuia")
                        .IsUnique();

                    b.HasIndex("ContratoId");

                    b.HasIndex("MedicoId")
                        .IsUnique();

                    b.ToTable("Guias");
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
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<Guid>("GuiaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nomeprest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rede")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Status")
                        .HasColumnType("bigint");

                    b.Property<string>("Tipoprest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Codprest")
                        .IsUnique()
                        .HasFilter("[Codprest] IS NOT NULL");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodUsu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ContratoId")
                        .HasColumnType("uniqueidentifier");

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

                    b.HasIndex("CodUsu")
                        .IsUnique()
                        .HasFilter("[CodUsu] IS NOT NULL");

                    b.HasIndex("ContratoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Models.Agendamento", b =>
                {
                    b.HasOne("Domain.Models.Medico", "Medico")
                        .WithMany("Agendamentos")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Guia", b =>
                {
                    b.HasOne("Domain.Models.Contrato", "Contrato")
                        .WithMany("Guias")
                        .HasForeignKey("ContratoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Medico", "Medico")
                        .WithOne("Guia")
                        .HasForeignKey("Domain.Models.Guia", "MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Medico", b =>
                {
                    b.HasOne("Domain.Models.Especialidade", "Especialidade")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.HasOne("Domain.Models.Contrato", "Contrato")
                        .WithMany("Usuarios")
                        .HasForeignKey("ContratoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
