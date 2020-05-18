using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class CreateGuiaDTO : BaseDTO
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
    }
}
