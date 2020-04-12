using Core.CQRS;

namespace Domain.Commands
{
    public class CreateContratoCommand : Command
    {
        public CreateContratoCommand(string codTit, string nomeTit, string situCont, string cpfTit)
        {
            Codtit = codTit;
            Nometit = nomeTit;
            Situcont = situCont;
            Cpftit = cpfTit;
        }
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
    }
}
