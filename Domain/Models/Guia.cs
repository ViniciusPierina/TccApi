using Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("cadguia")]
    public class Guia : BaseModel
    {
        public long CodGuia { get; set; }
        public int TipoCons { get; set; }
        public int CodPaciente { get; set; }
        public string NomePaciente { get; set; }
        public int CodPrestSolicitante { get; set; }
        public int CodPrestExecutante { get; set; }
        public int CodEspecMedico { get; set; }
        public int TipoGuia { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime HoraEmissao { get; set; }
        public DateTime DataAgendamento { get; set; }
        public DateTime HoraAgendamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime HoraVencimento { get; set; }
        public int CodProcedimento { get; set; }
        public float ValorConsulta { get; set; }
    }
}

//codguia(pk, bigint, not null),  (Codigo da Guia Sequencial)
//codsolicitante(fk, varchar, not null), (código do médico/clinica que solicitou a guia)
//codprestador(fk, varchar, not null,), (codigo do médico/clinica que solicitou a guia)
//codtit(fk, varchar, not null), (Código do contrato da pessoa)
//codusu(fk, varchar, not null), (código do usuario da pessoa)
//codAgendamento(fk, varchar, not null), (código do agendamento que vai conter a data e a hora da consulta)
//codlocal(Varchar, not null, fk), (código do local que vai ser realizado o atendimento)
//codespec_prest(fk , varchar, not null), (código do local de atendimento da clinica, onde a pessoa vai poder escolher caso tiver mais que uma clinica )
//dataemi(date, not null), (data do dia atual)
//hora(hora local, not null), (hora atual)
//codatend(varchar, not null), (001 fixo, pois é o código padrão da guia de consulta)
//validguia(date, not null), (30 dias após a data de emissão)
//tipocons(varchar, not null), (E fixo, pois é uma guia Eletiva)
//origem(varchar, not null), (S fixo, pois foi emitida pelo Smartphone)
//status(varchar, not null) (R - retorno, E - emitida, C - concluida, D - deletada)