using System;
using System.Collections.Generic;

namespace Services.DTOs
{
    public class EspecialidadeDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
        public ICollection<MedicoDTO> Medicos { get; set; }
    }
}
