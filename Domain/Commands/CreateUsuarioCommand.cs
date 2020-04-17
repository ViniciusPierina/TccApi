using Core.CQRS;
using Domain.Models;
using System;

namespace Domain.Commands
{
    public class CreateUsuarioCommand : Command
    {
        public CreateUsuarioCommand(string codUsu, string nome, string cpf, string status, string sexo,
            string situUsu)
        {
            CodUsu = codUsu;
            Nome = nome;
            Cpf = cpf;
            Status = status;
            Sexo = sexo;
            Situusu = situUsu;
        }
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
    }
}
