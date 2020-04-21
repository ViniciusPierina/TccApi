using Core.CQRS;
using Domain.Models;
using System;

namespace Domain.Commands
{
    public class CreateAgendamentoCommand : Command
    {
        public CreateAgendamentoCommand(int codigo, int codMedico, DateTime dataConsulta, DateTime horaConsulta,
            bool status)
        {
            Codigo = codigo;
            CodMedico = codMedico;
            DataConsulta = dataConsulta;
            HoraConsulta = horaConsulta;
            Status = status;
            //Medico = medico;
        }
        public int Codigo { get; set; }
        public int CodMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }
        public bool Status { get; set; }
        public Medico Medico { get; set; }
    }
}
