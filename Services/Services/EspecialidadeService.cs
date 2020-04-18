using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class EspecialidadeService : IEspecialidade
    {
        private readonly IRepository<Especialidade> _repository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;

        public EspecialidadeService(IRepository<Especialidade> repository, IMapper mapper, IBus bus)
        {
            _repository = repository;
            _mapper = mapper;
            _bus = bus;
        }
        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveEspecialidadeCommand(id));
        }
        public EspecialidadeDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
                return _mapper.Map<EspecialidadeDTO>(model);

            return null;
        }

        public IEnumerable<EspecialidadeDTO> GetAll()
        {
            IEnumerable<Especialidade> entityList = _repository.Get();
            List<EspecialidadeDTO> entityDTOList = new List<EspecialidadeDTO>();
            foreach (Especialidade entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<EspecialidadeDTO>(entity));
            }
            return entityDTOList;
        }

        public void Save(CreateEspecialidadeDTO model)
        {
            var especialidade = _mapper.Map<CreateEspecialidadeCommand>(model);
            _bus.SendCommand(especialidade);
        }

        public void Update(UpdateEspecialidadeDTO model)
        {
            var especialidade = _mapper.Map<UpdateEspecialidadeCommand>(model);
            _bus.SendCommand(especialidade);
        }
    }
}
