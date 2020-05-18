using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repositories
{
    public class GuiaRepository : Repository<Guia>
    {
        private readonly ConfigurationContext _context;

        public GuiaRepository(ConfigurationContext context) : base(context)
        {
            _context = context;
        }

        public override Guia Find(Guid id)
        {
            return _context
                .Set<Guia>()
                .Include(guia => guia.Medico)
                .ThenInclude(medico => medico.Especialidade)
                .Include(guia => guia.Medico)
                .ThenInclude(medico => medico.Agendamentos)
                .Include(guia => guia.Contrato)
                .ThenInclude(contrato => contrato.Usuarios)
                .FirstOrDefaultAsync(guia => guia.Id == id).Result;
        }
    }
}
