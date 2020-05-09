using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class CreateUsuarioCommand : Command
    {
        public CreateUsuarioCommand(string codUsu, string nome, string cpf, string status, string sexo,
            string situUsu, Guid contratoId)
        {
            CodUsu = codUsu;
            Nome = nome;
            Cpf = cpf;
            Status = status;
            Sexo = sexo;
            Situusu = situUsu;
            ContratoId = contratoId;
        }
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
        public Guid ContratoId { get; set; }
    }
}
