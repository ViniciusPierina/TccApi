using Core.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class UpdateContratoCommand : Command
    {
        public UpdateContratoCommand(Guid id, string codTit, string nomeTit, string situCont, string cpfTit)
        {
            Id = id;
            Codtit = codTit;
            Nometit = nomeTit;
            Situcont = situCont;
            Cpftit = cpfTit;
        }
        public Guid Id { get; set; }
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
    }
}
