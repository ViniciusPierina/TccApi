using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class CreateContratoCommand : Command
    {
        public CreateContratoCommand(string codTit, string nomeTit, string situCont, string cpfTit, Guid guiaId)
        {
            Codtit = codTit;
            Nometit = nomeTit;
            Situcont = situCont;
            Cpftit = cpfTit;
            GuiaId = guiaId;
        }
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
        public Guid GuiaId { get; set; }
    }
}
