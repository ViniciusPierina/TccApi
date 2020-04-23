using Core.Models;

namespace Domain.Models
{
    public class Contrato : BaseModel
    {
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
    }
}
