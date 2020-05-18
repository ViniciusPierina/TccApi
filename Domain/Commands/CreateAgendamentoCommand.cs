using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class CreateAgendamentoCommand : Command
    {
        public CreateAgendamentoCommand(int codigo, int codMedico, DateTime dataConsulta, DateTime horaConsulta, bool status, Guid medicoId)
        {
            Codigo = codigo;
            CodMedico = codMedico;
            DataConsulta = dataConsulta;
            HoraConsulta = horaConsulta;
            Status = status;
            MedicoId = medicoId;
        }
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
        public Guid MedicoId { get; set; }
    }
}
