using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Domain.Handlers.Commands
{
    public class EspecialidadeCommandHandler : IHandler<CreateEspecialidadeCommand>,
        IHandler<UpdateEspecialidadeCommand>,
        IHandler<RemoveEspecialidadeCommand>
    {
        private readonly IRepository<Especialidade> _repository;
        private readonly IMapper _mapper;
        public EspecialidadeCommandHandler(IRepository<Especialidade> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Handle(CreateEspecialidadeCommand Message)
        {
            if (Message != null)
            {
                var especialidade = _mapper.Map<Especialidade>(Message);
                especialidade.CreationDate = DateTime.Now;
                _repository.Add(especialidade);
            }
        }
        public void Handle(UpdateEspecialidadeCommand Message)
        {
            if (Message != null)
            {
                var especialidade = _mapper.Map<Especialidade>(Message);
                _repository.Update(especialidade);
            }
        }
        public void Handle(RemoveEspecialidadeCommand Message)
        {
            var especialidade = _repository.Find(Message.Id);
            if (especialidade != null)
            {
                _repository.Remove(Message.Id);
            }
        }
    }
}
