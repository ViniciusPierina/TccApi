using System;

namespace Services.DTOs
{
    public class CreateContratoDTO : BaseDTO
    {
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
    }
}
