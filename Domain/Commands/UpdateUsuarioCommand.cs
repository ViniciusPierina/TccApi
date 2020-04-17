using Core.CQRS;
using Domain.Models;
using System;

namespace Domain.Commands
{
    public class UpdateUsuarioCommand : Command
    {
        public UpdateUsuarioCommand(Guid id, string codUsu, string nome, string cpf, string status, string sexo,
            string situUsu)
        {
            Id = id;
            CodUsu = codUsu;
            Nome = nome;
            Cpf = cpf;
            Status = status;
            Sexo = sexo;
            Situusu = situUsu;
        }
        public Guid Id { get; set; }
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
    }
}
