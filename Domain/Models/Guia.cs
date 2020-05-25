using Core.Models;
using System;

namespace Domain.Models
{
    public class Guia : BaseModel
    {
        public long CodGuia { get; set; }
        public DateTime DataEmi { get; set; }
        public DateTime Hora { get; set; }
        public string CodAtend { get; set; }
        public DateTime ValidGuia { get; set; }
        public string TipoCons { get; set; }
        public string Origem { get; set; }
        public string Status { get; set; }
        public Guid MedicoId { get; set; }
        public Guid ContratoId { get; set; }
        public Medico Medico { get; set; }
        public Contrato Contrato { get; set; }
    }
}