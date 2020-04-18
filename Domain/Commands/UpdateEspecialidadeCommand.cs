using Core.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class UpdateEspecialidadeCommand : Command
    {
        public UpdateEspecialidadeCommand(Guid id, string codeSpec, string desceSpec, string status)
        {
            Id = id;
            Codespec = codeSpec;
            Descespec = desceSpec;
            Status = status;
        }
        public Guid Id { get; set; }
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
    }
}
