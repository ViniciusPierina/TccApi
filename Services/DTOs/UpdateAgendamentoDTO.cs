using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class UpdateAgendamentoDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
    }
}
