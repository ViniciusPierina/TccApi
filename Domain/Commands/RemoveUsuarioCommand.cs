using Core.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class RemoveUsuarioCommand : Command
    {
        public RemoveUsuarioCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
