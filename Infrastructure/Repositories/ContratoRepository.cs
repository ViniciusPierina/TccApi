using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repositories
{
    public class ContratoRepository : Repository<Contrato>
    {
        private readonly ConfigurationContext _context;

        public ContratoRepository(ConfigurationContext context) : base(context)
        {
            _context = context;
        }

        public override Contrato Find(Guid id)
        {
            return _context
                .Set<Contrato>()
                .Include(contrato => contrato.Usuarios)
                .Include(contrato => contrato.Guia)
                .FirstOrDefaultAsync(contrato => contrato.Id == id).Result;
        }
    }
}
