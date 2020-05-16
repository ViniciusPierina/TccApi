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
                .Include(guia => guia.Contrato)
                .FirstOrDefaultAsync(guia => guia.Id == id).Result;
        }
    }
}
