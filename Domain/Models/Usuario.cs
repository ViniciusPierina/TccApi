using Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("cadusu")]
    public class Usuario : BaseModel
    {
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
    }
}
