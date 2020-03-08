using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class UpdateGuiaDTO : BaseDTO
    {
        public Guid Id { get; set; }
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
