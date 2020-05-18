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
    public class MedicoService : IMedicoService
    {
        private readonly IRepository<Medico> _repository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;
        public MedicoService(IRepository<Medico> repository, IMapper mapper, IBus bus)
        {
            _repository = repository;
            _mapper = mapper;
            _bus = bus;
        }
        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveMedicoCommand(id));
        }
        public MedicoDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
                return _mapper.Map<MedicoDTO>(model);

            return null;
        }
        public IEnumerable<MedicoDTO> GetAll()
        {
            IEnumerable<Medico> entityList = _repository.Get();
            List<MedicoDTO> entityDTOList = new List<MedicoDTO>();
            foreach (Medico entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<MedicoDTO>(entity));
            }
            return entityDTOList;
        }
        public void Save(CreateMedicoDTO model)
        {
            var medico = _mapper.Map<CreateMedicoCommand>(model);
            _bus.SendCommand(medico);
        }
        public void Update(UpdateMedicoDTO model)
        {
            var medico = _mapper.Map<UpdateMedicoCommand>(model);
            _bus.SendCommand(medico);
        }
    }
}
