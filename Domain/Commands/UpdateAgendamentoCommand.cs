using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class UpdateAgendamentoCommand : Command
    {
        public UpdateAgendamentoCommand(Guid id, int codigo, int codMedico, DateTime dataConsulta, DateTime horaConsulta, bool status, Guid medicoId)
        {
            Id = id;
            Codigo = codigo;
            CodMedico = codMedico;
            DataConsulta = dataConsulta;
            HoraConsulta = horaConsulta;
            Status = status;
            MedicoId = medicoId;
        }
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
        public Guid MedicoId { get; set; }
    }
}
