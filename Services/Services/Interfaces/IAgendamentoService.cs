using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface IAgendamentoService
    {
        void Save(CreateAgendamentoDTO model);
        void Update(UpdateAgendamentoDTO model);
        void Delete(Guid Id);
        AgendamentoDTO Get(Guid Id);
        IEnumerable<AgendamentoDTO> GetAll();
    }
}
