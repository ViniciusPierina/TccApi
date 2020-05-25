﻿using Core.CQRS;
using System;

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
