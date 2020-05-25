using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class RemoveGuiaCommand : Command
    {
        public RemoveGuiaCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
