using Core.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class CreateGuiaCommand : Command
    {
        public CreateGuiaCommand(int codGuia, int tipoCons, int codPaciente, string nomePaciente, 
            int codPrestSolicitante, int codPrestExecutante, int codEspecMedico, int tipoGuia, DateTime dataEmissao,
            DateTime horaEmissao, DateTime dataAgendamento, DateTime horaAgendamento, DateTime dataVencimento,
            DateTime horaVencimento, int codProcedimento, float valorConsulta)
        {
            CodGuia = codGuia;
            TipoCons = tipoCons;
            CodPaciente = codPaciente;
            NomePaciente = nomePaciente;
            CodPrestSolicitante = codPrestSolicitante;
            CodPrestExecutante = codPrestExecutante;
            CodEspecMedico = codEspecMedico;
            TipoGuia = tipoGuia;
            DataEmissao = dataEmissao;
            HoraEmissao = horaEmissao;
            DataAgendamento = dataAgendamento;
            HoraAgendamento = horaAgendamento;
            DataVencimento = dataVencimento;
            HoraVencimento = horaVencimento;
            CodProcedimento = codProcedimento;
            ValorConsulta = valorConsulta;
        }
        public int CodGuia { get; set; }
        public int TipoCons { get; set; }
        public int CodPaciente { get; set; }
        public string NomePaciente { get; set; }
        public int CodPrestSolicitante { get; set; }
        public int CodPrestExecutante { get; set; }
        public int CodEspecMedico { get; set; }
        public int TipoGuia { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime HoraEmissao { get; set; }
        public DateTime DataAgendamento { get; set; }
        public DateTime HoraAgendamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime HoraVencimento { get; set; }
        public int CodProcedimento { get; set; }
        public float ValorConsulta { get; set; }
    }
}
