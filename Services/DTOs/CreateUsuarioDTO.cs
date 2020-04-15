using Domain.Models;
using System;

namespace Services.DTOs
{
    public class CreateUsuarioDTO : BaseDTO
    {
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
        public Contrato Contrato { get; set; }
        public Guid ContratoId { get; set; }
    }
}
