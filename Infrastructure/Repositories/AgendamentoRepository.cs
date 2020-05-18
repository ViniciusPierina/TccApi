using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repositories
{
    public class AgendamentoRepository : Repository<Agendamento>
    {
        private readonly ConfigurationContext _context;

        public AgendamentoRepository(ConfigurationContext context) : base(context)
        {
            _context = context;
        }

        public override Agendamento Find(Guid id)
        {
            return _context
                .Set<Agendamento>()
                .Include(agendamento => agendamento.Medico)
                .ThenInclude(medico => medico.Especialidade)
                .FirstOrDefaultAsync(agendamento => agendamento.Id == id).Result;
        }
    }
}
