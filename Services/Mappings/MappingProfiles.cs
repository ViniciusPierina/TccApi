﻿using AutoMapper;
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
        }
    }
}