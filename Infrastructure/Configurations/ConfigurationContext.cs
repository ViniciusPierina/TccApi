using Domain.Models;
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
    }
}
