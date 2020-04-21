using Domain.Models;
using System.Collections.Generic;

namespace Services.DTOs
{
    public class CreateEspecialidadeDTO : BaseDTO
    {
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
        public ICollection<Medico> Medicos { get; set; }
    }
}
