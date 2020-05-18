using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Handlers.Commands
{
    public class AgendamentoCommandHandler : IHandler<CreateAgendamentoCommand>,
        IHandler<UpdateAgendamentoCommand>,
        IHandler<RemoveAgendamentoCommand>
    {
        private readonly IRepository<Agendamento> _repository;
        private readonly IMapper _mapper;
        public AgendamentoCommandHandler(IRepository<Agendamento> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(CreateAgendamentoCommand Message)
        {
            if (Message != null)
            {
                var agendamento = _mapper.Map<Agendamento>(Message);
                agendamento.CreationDate = DateTime.Now;
                _repository.Add(agendamento);
            }
        }
        public void Handle(UpdateAgendamentoCommand Message)
        {
            if (Message != null)
            {
                var agendamento = _mapper.Map<Agendamento>(Message);
                _repository.Update(agendamento);
            }
        }
        public void Handle(RemoveAgendamentoCommand Message)
        {
            var agendamento = _repository.Find(Message.Id);
            if (agendamento != null)
            {
                _repository.Remove(Message.Id);
            }
        }
    }
}
