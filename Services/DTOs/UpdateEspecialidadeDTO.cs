using System;

namespace Services.DTOs
{
    public class UpdateEspecialidadeDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
    }
}
