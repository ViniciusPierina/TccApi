using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Domain.Handlers.Commands
{
    public class MedicoCommandHandler : IHandler<CreateMedicoCommand>,
        IHandler<UpdateMedicoCommand>,
        IHandler<RemoveMedicoCommand>
    {
        private readonly IRepository<Medico> _repository;
        private readonly IMapper _mapper;
        public MedicoCommandHandler(IRepository<Medico> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Handle(CreateMedicoCommand Message)
        {
            if (Message != null)
            {
                var medico = _mapper.Map<Medico>(Message);
                medico.CreationDate = DateTime.Now;
                _repository.Add(medico);
            }
        }
        public void Handle(UpdateMedicoCommand Message)
        {
            if (Message != null)
            {
                var medico = _mapper.Map<Medico>(Message);
                _repository.Update(medico);
            }
        }
        public void Handle(RemoveMedicoCommand Message)
        {
            var medico = _repository.Find(Message.Id);
            if (medico != null)
            {
                _repository.Remove(Message.Id);
            }
        }
    }
}
