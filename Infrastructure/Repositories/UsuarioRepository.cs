using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        private readonly ConfigurationContext _context;

        public UsuarioRepository(ConfigurationContext context) : base(context)
        {
            _context = context;
        }

        public override Usuario Find(Guid id)
        {
            return _context
                .Set<Usuario>()
                .Include(usuario => usuario.Contrato)
                .FirstOrDefaultAsync(usuario => usuario.Id == id).Result;
        }
    }
}
