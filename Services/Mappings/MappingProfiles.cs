using AutoMapper;
using Domain.Commands;
using Domain.Models;
using Services.DTOs;

namespace Services.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Guia, GuiaDTO>().ReverseMap();
            CreateMap<CreateGuiaCommand, CreateGuiaDTO>().ReverseMap();
            CreateMap<UpdateGuiaCommand, UpdateGuiaDTO>().ReverseMap();
            CreateMap<Guia, CreateGuiaCommand>().ReverseMap();
            CreateMap<Guia, UpdateGuiaCommand>().ReverseMap();

            CreateMap<Agendamento, AgendamentoDTO>().ReverseMap();
            CreateMap<CreateAgendamentoCommand, CreateAgendamentoDTO>().ReverseMap();
            CreateMap<UpdateAgendamentoCommand, UpdateAgendamentoDTO>().ReverseMap();
            CreateMap<Agendamento, CreateAgendamentoCommand>().ReverseMap();
            CreateMap<Agendamento, UpdateAgendamentoCommand>().ReverseMap();

            CreateMap<Contrato, ContratoDTO>().ReverseMap();
            CreateMap<CreateContratoCommand, CreateContratoDTO>().ReverseMap();
            CreateMap<UpdateContratoCommand, UpdateContratoDTO>().ReverseMap();
            CreateMap<Contrato, CreateContratoCommand>().ReverseMap();
            CreateMap<Contrato, UpdateContratoCommand>().ReverseMap();

            CreateMap<Medico, MedicoDTO>().ReverseMap();
            CreateMap<CreateMedicoCommand, CreateMedicoDTO>().ReverseMap();
            CreateMap<UpdateMedicoCommand, UpdateMedicoDTO>().ReverseMap();
            CreateMap<Medico, CreateMedicoCommand>().ReverseMap();
            CreateMap<Medico, UpdateMedicoCommand>().ReverseMap();

            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<CreateUsuarioCommand, CreateUsuarioDTO>().ReverseMap();
            CreateMap<UpdateUsuarioCommand, UpdateUsuarioDTO>().ReverseMap();
            CreateMap<Usuario, CreateUsuarioCommand>().ReverseMap();
            CreateMap<Usuario, UpdateUsuarioCommand>().ReverseMap();
        }
    }
}
