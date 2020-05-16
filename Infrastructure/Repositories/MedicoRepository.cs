using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repositories
{
    public class MedicoRepository : Repository<Medico>
    {
        private readonly ConfigurationContext _context;

        public MedicoRepository(ConfigurationContext context) : base(context)
        {
            _context = context;
        }

        public override Medico Find(Guid id)
        {
            return _context
                .Set<Medico>()
                .Include(medico => medico.Especialidade)
                .Include(medico => medico.Agendamentos)
                .Include(medico => medico.Guia)
                .FirstOrDefaultAsync(medico => medico.Id == id).Result;
        }
    }
}
