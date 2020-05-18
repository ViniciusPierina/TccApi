using Core.CQRS;

namespace Domain.Commands
{
    public class CreateEspecialidadeCommand : Command
    {
        public CreateEspecialidadeCommand(string codeSpec, string desceSpec, string status)
        {
            Codespec = codeSpec;
            Descespec = desceSpec;
            Status = status;
        }
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
    }
}
