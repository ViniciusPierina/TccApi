using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Agendamento : BaseModel
    {
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
        public Medico Medico { get; set; }
    }
}
