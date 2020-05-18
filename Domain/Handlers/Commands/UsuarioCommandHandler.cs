using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Domain.Handlers.Commands
{
    public class UsuarioCommandHandler : IHandler<CreateUsuarioCommand>,
        IHandler<UpdateUsuarioCommand>,
        IHandler<RemoveUsuarioCommand>
    {
        private readonly IRepository<Usuario> _repository;
        private readonly IMapper _mapper;
        public UsuarioCommandHandler(IRepository<Usuario> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Handle(CreateUsuarioCommand Message)
        {
            if (Message != null)
            {
                var usuario = _mapper.Map<Usuario>(Message);
                usuario.CreationDate = DateTime.Now;
                _repository.Add(usuario);
            }
        }
        public void Handle(UpdateUsuarioCommand Message)
        {
            if (Message != null)
            {
                var usuario = _mapper.Map<Usuario>(Message);
                _repository.Update(usuario);
            }
        }
        public void Handle(RemoveUsuarioCommand Message)
        {
            var usuario = _repository.Find(Message.Id);
            if (usuario != null)
            {
                _repository.Remove(Message.Id);
            }
        }
    }
}
