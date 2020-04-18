using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class EspecialidadeDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string Codespec { get; set; }
        public string Descespec { get; set; }
        public string Status { get; set; }
    }
}
