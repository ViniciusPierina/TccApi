using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface IMedicoService
    {
        void Save(CreateMedicoDTO model);
        void Update(UpdateMedicoDTO model);
        void Delete(Guid Id);
        MedicoDTO Get(Guid Id);
        IEnumerable<MedicoDTO> GetAll();
    }
}
