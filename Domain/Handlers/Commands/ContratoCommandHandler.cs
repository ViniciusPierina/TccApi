using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Domain.Handlers.Commands
{
    public class ContratoCommandHandler : IHandler<CreateContratoCommand>,
        IHandler<UpdateContratoCommand>,
        IHandler<RemoveContratoCommand>
    {
        private readonly IRepository<Contrato> _repository;
        private readonly IMapper _mapper;
        public ContratoCommandHandler(IRepository<Contrato> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Handle(CreateContratoCommand Message)
        {
            if (Message != null)
            {
                var contrato = _mapper.Map<Contrato>(Message);
                contrato.CreationDate = DateTime.Now;
                _repository.Add(contrato);
            }
        }
        public void Handle(UpdateContratoCommand Message)
        {
            if (Message != null)
            {
                var contrato = _mapper.Map<Contrato>(Message);
                _repository.Update(contrato);
            }
        }
        public void Handle(RemoveContratoCommand Message)
        {
            var contrato = _repository.Find(Message.Id);
            if (contrato != null)
            {
                _repository.Remove(Message.Id);
            }
        }
    }
}
