﻿using System;

namespace Services.DTOs
{
    public class CreateMedicoDTO : BaseDTO
    {
        public string Codprest { get; set; }
        public string Nomeprest { get; set; }
        public string Tipoprest { get; set; }
        public string Endprest { get; set; }
        public string Baiprest { get; set; }
        public string Cidprest { get; set; }
        public string Categprest { get; set; }
        public string Foneprest { get; set; }
        public string Codesp { get; set; }
        public long Status { get; set; }
        public string Conselho { get; set; }
        public string Rede { get; set; }
        public string Crmprest { get; set; }
        public Guid EspecialidadeId { get; set; }
        public Guid GuiaId { get; set; }
    }
}
