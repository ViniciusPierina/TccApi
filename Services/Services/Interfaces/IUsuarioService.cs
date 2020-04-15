using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface IUsuarioService
    {
        void Save(CreateUsuarioDTO model);
        void Update(UpdateUsuarioDTO model);
        void Delete(Guid Id);
        UsuarioDTO Get(Guid Id);
        IEnumerable<UsuarioDTO> GetAll();
    }
}
