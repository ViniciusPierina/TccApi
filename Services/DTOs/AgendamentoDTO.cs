using System;

namespace Services.DTOs
{
    public class AgendamentoDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
        public MedicoDTO Medico { get; set; }
    }
}
