using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class UpdateUsuarioCommand : Command
    {
        public UpdateUsuarioCommand(Guid id, string codUsu, string nome, string cpf, string email, string status, string sexo, string situUsu, Guid contratoId)
        {
            Id = id;
            CodUsu = codUsu;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Status = status;
            Sexo = sexo;
            Situusu = situUsu;
            ContratoId = contratoId;
        }
        public Guid Id { get; set; }
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
        public Guid ContratoId { get; set; }
    }
}
