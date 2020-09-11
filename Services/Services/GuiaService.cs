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
    public class GuiaService : IGuiaService
    {
        private readonly IRepository<Guia> _repository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;
        private readonly IContratoService _contratoService;

        public GuiaService(IRepository<Guia> repository, IMapper mapper, IBus bus, IContratoService contratoService)
        {
            _repository = repository;
            _mapper = mapper;
            _bus = bus;
            _contratoService = contratoService;
        }
        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveGuiaCommand(id));
        }

        public GuiaDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
                return _mapper.Map<GuiaDTO>(model);

            return null;
        }

        public IEnumerable<GuiaDTO> GetAll()
        {
            IEnumerable<Guia> entityList = _repository.Get();
            List<GuiaDTO> entityDTOList = new List<GuiaDTO>();
            foreach (Guia entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<GuiaDTO>(entity));
            }
            return entityDTOList;
        }

        public void Save(CreateGuiaDTO model)
        {
            var guia = _mapper.Map<CreateGuiaCommand>(model);
            var contrato = _contratoService.Get(model.ContratoId);

            if (contrato.Situcont == "Inativo")
                throw new ArgumentException("O contrato do titular está inativo");

            _bus.SendCommand(guia);
        }

        public void Update(UpdateGuiaDTO model)
        {
            var guia = _mapper.Map<UpdateGuiaCommand>(model);
            _bus.SendCommand(guia);
        }
    }
}
