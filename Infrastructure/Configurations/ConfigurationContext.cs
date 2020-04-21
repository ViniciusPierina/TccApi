﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
            builder.Entity<Medico>().HasKey(x => x.Id);
            builder.Entity<Especialidade>().HasKey(x => x.Id);
            builder.Entity<Agendamento>().HasKey(x => x.Id);
            builder.Entity<Medico>().HasOne(x => x.Especialidade).WithMany(x => x.Medicos);
            builder.Entity<Medico>().HasMany(x => x.Agendamentos).WithOne(x => x.Medico);
        }
    }
}
