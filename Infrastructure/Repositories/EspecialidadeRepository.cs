using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repositories
{
    public class EspecialidadeRepository : Repository<Especialidade>
    {
        private readonly ConfigurationContext _context;

        public EspecialidadeRepository(ConfigurationContext context) : base(context)
        {
            _context = context;
        }

        public override Especialidade Find(Guid id)
        {
            return _context
                .Set<Especialidade>()
                .Include(especialidade => especialidade.Medicos)
                .FirstOrDefaultAsync(especialidade => especialidade.Id == id).Result;
        }
    }
}
