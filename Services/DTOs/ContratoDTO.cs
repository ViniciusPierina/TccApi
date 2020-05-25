using System;
using System.Collections.Generic;

namespace Services.DTOs
{
    public class ContratoDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
        public ICollection<UsuarioDTO> Usuarios { get; set; }
        public ICollection<GuiaDTO> Guias { get; set; }
    }
}
