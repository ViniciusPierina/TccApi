using Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("cadcont")]
    public class Contrato : BaseModel
    {
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
    }
}
