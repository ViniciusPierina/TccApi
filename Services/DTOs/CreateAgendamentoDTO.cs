using Domain.Models;
using System;

namespace Services.DTOs
{
    public class CreateAgendamentoDTO : BaseDTO
    {
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
        public Medico Medico { get; set; }
    }
}
