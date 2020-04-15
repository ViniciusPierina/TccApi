using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepository<Usuario> _repository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;
        public UsuarioService(IRepository<Usuario> repository, IMapper mapper, IBus bus)
        {
            _repository = repository;
            _mapper = mapper;
            _bus = bus;
        }
        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveUsuarioCommand(id));
        }
        public UsuarioDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
                return _mapper.Map<UsuarioDTO>(model);

            return null;
        }
        public IEnumerable<UsuarioDTO> GetAll()
        {
            IEnumerable<Usuario> entityList = _repository.Get();
            List<UsuarioDTO> entityDTOList = new List<UsuarioDTO>();
            foreach (Usuario entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<UsuarioDTO>(entity));
            }
            return entityDTOList;
        }
        public void Save(CreateUsuarioDTO model)
        {
            var usuario = _mapper.Map<CreateUsuarioCommand>(model);
            _bus.SendCommand(usuario);
        }
        public void Update(UpdateUsuarioDTO model)
        {
            var usuario = _mapper.Map<UpdateUsuarioCommand>(model);
            _bus.SendCommand(usuario);
        }
    }
}
