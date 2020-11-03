using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
	public interface ILoginRepository
	{
		public Usuario GetUsuarioLogin(string email, string cpf);
	}
}
