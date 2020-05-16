using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class UpdateContratoCommand : Command
    {
        public UpdateContratoCommand(Guid id, string codTit, string nomeTit, string situCont, string cpfTit, Guid guiaId)
        {
            Id = id;
            Codtit = codTit;
            Nometit = nomeTit;
            Situcont = situCont;
            Cpftit = cpfTit;
            GuiaId = guiaId;
        }
        public Guid Id { get; set; }
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
        public Guid GuiaId { get; set; }
    }
}
