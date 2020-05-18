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
    public class ContratoService : IContratoService
    {
        private readonly IRepository<Contrato> _repository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;
        public ContratoService(IRepository<Contrato> repository, IMapper mapper, IBus bus)
        {
            _repository = repository;
            _mapper = mapper;
            _bus = bus;
        }
        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveContratoCommand(id));
        }
        public ContratoDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
                return _mapper.Map<ContratoDTO>(model);

            return null;
        }
        public IEnumerable<ContratoDTO> GetAll()
        {
            IEnumerable<Contrato> entityList = _repository.Get();
            List<ContratoDTO> entityDTOList = new List<ContratoDTO>();
            foreach (Contrato entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<ContratoDTO>(entity));
            }
            return entityDTOList;
        }
        public void Save(CreateContratoDTO model)
        {
            var contrato = _mapper.Map<CreateContratoCommand>(model);
            _bus.SendCommand(contrato);
        }
        public void Update(UpdateContratoDTO model)
        {
            var contrato = _mapper.Map<UpdateContratoCommand>(model);
            _bus.SendCommand(contrato);
        }
    }
}
