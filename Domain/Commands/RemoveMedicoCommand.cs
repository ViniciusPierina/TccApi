using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class RemoveMedicoCommand : Command
    {
        public RemoveMedicoCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
