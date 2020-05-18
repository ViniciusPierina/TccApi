using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface IContratoService
    {
        void Save(CreateContratoDTO model);
        void Update(UpdateContratoDTO model);
        void Delete(Guid Id);
        ContratoDTO Get(Guid Id);
        IEnumerable<ContratoDTO> GetAll();
    }
}
