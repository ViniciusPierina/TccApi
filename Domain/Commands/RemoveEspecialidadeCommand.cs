using Core.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class RemoveEspecialidadeCommand : Command
    {
        public RemoveEspecialidadeCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
