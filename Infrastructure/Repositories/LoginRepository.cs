using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
	public class LoginRepository : ILoginRepository
	{
        private readonly ConfigurationContext _context;

        public LoginRepository(ConfigurationContext context)
        {
            _context = context;
        }

        public Usuario GetUsuarioLogin(string email, string cpf)
        {
            return _context
                .Set<Usuario>()
                .FirstOrDefaultAsync(usuario => usuario.Email == email && usuario.Cpf == cpf).Result;
        }
    }
}
