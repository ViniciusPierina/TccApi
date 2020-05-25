using Core.Models;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Contrato : BaseModel
    {
        public string Codtit { get; set; }
        public string Nometit { get; set; }
        public string Situcont { get; set; }
        public string Cpftit { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Guia> Guias { get; set; }
    }
}
