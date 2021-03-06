﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations
{
    public sealed class ConfigurationContext : DbContext
    {
        public ConfigurationContext(DbContextOptions<ConfigurationContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Guia> Guias { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Nome das tabelas
            builder.Entity<Agendamento>().ToTable("Agendamentos");
            builder.Entity<Contrato>().ToTable("Contratos");
            builder.Entity<Especialidade>().ToTable("Especialidades");
            builder.Entity<Guia>().ToTable("Guias");
            builder.Entity<Medico>().ToTable("Medicos");
            builder.Entity<Usuario>().ToTable("Usuarios");

            // Chaves Primárias
            builder.Entity<Agendamento>().HasKey(x => x.Id);
            builder.Entity<Contrato>().HasKey(x => x.Id);
            builder.Entity<Especialidade>().HasKey(x => x.Id);
            builder.Entity<Guia>().HasKey(x => x.Id);
            builder.Entity<Medico>().HasKey(x => x.Id);
            builder.Entity<Usuario>().HasKey(x => x.Id);

            // Auto-incrementos para IDs/PKs
            builder.Entity<Agendamento>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Contrato>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Especialidade>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Guia>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Medico>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Usuario>().Property(x => x.Id).ValueGeneratedOnAdd();

            // Indexes - Tanto Unicos quanto Não-Clusterizados
            builder.Entity<Agendamento>().HasIndex(entity => new {entity.DataConsulta, entity.CodMedico}).IsClustered(false);
            builder.Entity<Contrato>().HasIndex(x => x.Codtit).IsUnique();
            builder.Entity<Especialidade>().HasIndex(x => x.Codespec).IsUnique();
            builder.Entity<Guia>().HasIndex(x => x.CodGuia).IsUnique();
            builder.Entity<Medico>().HasIndex(x => x.Codprest).IsUnique();
            builder.Entity<Usuario>().HasIndex(x => x.CodUsu).IsUnique();

            // Chaves Estrangeiras / Relacionamentos
            builder.Entity<Medico>().HasOne(x => x.Especialidade).WithMany(x => x.Medicos).HasForeignKey(x => x.EspecialidadeId);
            builder.Entity<Medico>().HasMany(x => x.Agendamentos).WithOne(x => x.Medico);
            builder.Entity<Medico>().HasOne(x => x.Guia).WithOne(x => x.Medico);
            builder.Entity<Contrato>().HasMany(x => x.Usuarios).WithOne(x => x.Contrato);
            builder.Entity<Contrato>().HasMany(x => x.Guias).WithOne(x => x.Contrato);
            builder.Entity<Guia>().HasOne(x => x.Medico).WithOne(x => x.Guia).HasForeignKey<Guia>(x => x.MedicoId);
        }
    }
}
