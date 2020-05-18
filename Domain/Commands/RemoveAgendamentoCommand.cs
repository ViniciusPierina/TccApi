using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class RemoveAgendamentoCommand : Command
    {
        public RemoveAgendamentoCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
