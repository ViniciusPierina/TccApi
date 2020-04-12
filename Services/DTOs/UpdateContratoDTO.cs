using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class UpdateContratoDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
    }
}
