using Core.CQRS;
using Domain.Models;
using System;
using System.Collections.Generic;

namespace Domain.Commands
{
    public class CreateMedicoCommand : Command
    {
        public CreateMedicoCommand(string codPrest, string nomePrest, string tipoPrest, string endPrest, string baiPrest, 
            string cidPrest, string categPrest, string fonePrest, string codeSp, long status, string conselho,
            string rede, string crmPrest)
        {
            Codprest = codPrest;
            Nomeprest = nomePrest;
            Tipoprest = tipoPrest;
            Endprest = endPrest;
            Baiprest = baiPrest;
            Cidprest = cidPrest;
            Categprest = categPrest;
            Foneprest = fonePrest;
            Codesp = codeSp;
            Status = status;
            Conselho = conselho;
            Rede = rede;
            Crmprest = crmPrest;
            //Especialidade = especialidade;
            //EspecialidadeId = especialidadeId;
            //Agendamentos = agendamentos;
    }
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
        public Especialidade Especialidade { get; set; }
        //public Guid EspecialidadeId { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; }
    }
}
