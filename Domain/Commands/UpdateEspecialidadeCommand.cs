using Core.CQRS;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class UpdateEspecialidadeCommand : Command
    {
        public UpdateEspecialidadeCommand(Guid id, string codeSpec, string desceSpec, string status,
            ICollection<Medico> medicos)
        {
            Id = id;
            Codespec = codeSpec;
            Descespec = desceSpec;
            Status = status;
            Medicos = medicos;
        }
        public Guid Id { get; set; }
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
        public ICollection<Medico> Medicos { get; set; }
    }
}
