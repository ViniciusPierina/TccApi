using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class UpdateAgendamentoCommand : Command
    {
        public UpdateAgendamentoCommand(Guid id, int codigo, int codMedico, DateTime dataConsulta, DateTime horaConsulta,
            bool status)
        {
            Id = id;
            Codigo = codigo;
            CodMedico = codMedico;
            DataConsulta = dataConsulta;
            HoraConsulta = horaConsulta;
            Status = status;
        }
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
    }
}
