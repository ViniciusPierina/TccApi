using Core.CQRS;
using System;

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
