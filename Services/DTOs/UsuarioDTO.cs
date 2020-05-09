using System;

namespace Services.DTOs
{
    public class UsuarioDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string CodUsu { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Situusu { get; set; }
        public ContratoDTO Contrato { get; set; }
    }
}
