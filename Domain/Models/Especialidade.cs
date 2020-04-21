using Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("cadespec")]
    public class Especialidade : BaseModel
    {
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
        public ICollection<Medico> Medicos { get; set; }
    }
}
