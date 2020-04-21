using Core.CQRS;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Commands
{
    public class CreateEspecialidadeCommand : Command
    {
        public CreateEspecialidadeCommand(string codeSpec, string desceSpec, string status,
            ICollection<Medico> medicos)
        {
            Codespec = codeSpec;
            Descespec = desceSpec;
            Status = status;
            Medicos = medicos;
        }
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
        public ICollection<Medico> Medicos { get; set; }
    }
}
