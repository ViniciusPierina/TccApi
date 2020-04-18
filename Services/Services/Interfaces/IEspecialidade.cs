using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface IEspecialidade
    {
        void Save(CreateEspecialidadeDTO model);
        void Update(UpdateEspecialidadeDTO model);
        void Delete(Guid Id);
        EspecialidadeDTO Get(Guid Id);
        IEnumerable<EspecialidadeDTO> GetAll();
    }
}
