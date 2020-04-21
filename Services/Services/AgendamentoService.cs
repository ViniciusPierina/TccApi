using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IRepository<Agendamento> _repository;
        private readonly IMedicoService _medicoService;
        private readonly IMapper _mapper;
        private readonly IBus _bus;

        public AgendamentoService(IRepository<Agendamento> repository, IMapper mapper, IBus bus, IMedicoService medicoService)
        {
            _repository = repository;
            _medicoService = medicoService;
            _mapper = mapper;
            _bus = bus;
        }
        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveAgendamentoCommand(id));
        }

        public AgendamentoDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
                return _mapper.Map<AgendamentoDTO>(model);

            return null;
        }

        public IEnumerable<AgendamentoDTO> GetAll()
        {
            IEnumerable<Agendamento> entityList = _repository.Get();
            List<AgendamentoDTO> entityDTOList = new List<AgendamentoDTO>();
            foreach (Agendamento entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<AgendamentoDTO>(entity));
            }
            return entityDTOList;
        }

        public void Save(CreateAgendamentoDTO model)
        {
            var agendamento = _mapper.Map<CreateAgendamentoCommand>(model);
            agendamento.Medico = _mapper.Map<Medico>(_medicoService.GetAll().FirstOrDefault(x => x.Codprest == agendamento.CodMedico.ToString()));
            _bus.SendCommand(agendamento);
        }

        public void Update(UpdateAgendamentoDTO model)
        {
            var agendamento = _mapper.Map<UpdateAgendamentoCommand>(model);
            agendamento.Medico = _mapper.Map<Medico>(_medicoService.GetAll().FirstOrDefault(x => x.Codprest == agendamento.CodMedico.ToString()));
            _bus.SendCommand(agendamento);
        }
    }
}
