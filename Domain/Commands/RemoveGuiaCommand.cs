using Core.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

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
