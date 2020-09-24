using Core.Models;
using System;

namespace Domain.Models
{
    public class Usuario : BaseModel
    {
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
        public Contrato Contrato { get; set; }
        public Guid ContratoId { get; set; }
    }
}
