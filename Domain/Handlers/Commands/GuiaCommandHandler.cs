using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Domain.Handlers.Commands
{
    public class GuiaCommandHandler : IHandler<CreateGuiaCommand>,
        IHandler<UpdateGuiaCommand>,
        IHandler<RemoveGuiaCommand>
    {
        private readonly IRepository<Guia> _repository;
        private readonly IMapper _mapper;
        public GuiaCommandHandler(IRepository<Guia> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(CreateGuiaCommand Message)
        {
            if (Message != null)
            {
                var guia = _mapper.Map<Guia>(Message);
                guia.CreationDate = DateTime.Now;
                _repository.Add(guia);
            }
        }
        public void Handle(UpdateGuiaCommand Message)
        {
            if (Message != null)
            {
                var guia = _mapper.Map<Guia>(Message);
                _repository.Update(guia);
            }
        }
        public void Handle(RemoveGuiaCommand Message)
        {
            var guia = _repository.Find(Message.Id);
            if (guia != null)
            {
                _repository.Remove(Message.Id);
            }
        }
    }
}
