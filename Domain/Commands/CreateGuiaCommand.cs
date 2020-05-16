using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class CreateGuiaCommand : Command
    {
        public CreateGuiaCommand(int codGuia, DateTime dataEmi, DateTime hora, string codAtend, DateTime validGuia,
            string tipoCons, string origem, string status, Guid medicoId, Guid contratoId)
        {
            CodGuia = codGuia;
            DataEmi = dataEmi;
            Hora = hora;
            CodAtend = codAtend;
            ValidGuia = validGuia;
            TipoCons = tipoCons;
            Origem = origem;
            Status = status;
            MedicoId = medicoId;
            ContratoId = contratoId;

        }
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
