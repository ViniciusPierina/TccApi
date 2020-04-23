using Core.Models;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Especialidade : BaseModel
    {
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
        public ICollection<Medico> Medicos { get; set; }
    }
}
