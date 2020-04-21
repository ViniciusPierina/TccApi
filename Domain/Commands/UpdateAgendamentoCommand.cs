using Core.CQRS;
using Domain.Models;
using System;

namespace Domain.Commands
{
    public class UpdateAgendamentoCommand : Command
    {
        public UpdateAgendamentoCommand(Guid id, int codigo, int codMedico, DateTime dataConsulta, DateTime horaConsulta,
            bool status, Medico medico)
        {
            Id = id;
            Codigo = codigo;
            CodMedico = codMedico;
            DataConsulta = dataConsulta;
            HoraConsulta = horaConsulta;
            Status = status;
            Medico = medico;
        }
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
        public Medico Medico { get; set; }
    }
}
