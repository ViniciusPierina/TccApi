using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services.Interfaces
{
    public interface IGuiaService
    {
        void Save(CreateGuiaDTO model);
        void Update(UpdateGuiaDTO model);
        void Delete(Guid Id);
        GuiaDTO Get(Guid Id);
        IEnumerable<GuiaDTO> GetAll();
    }
}
