using AutoMapper;
using GarageSoft.Domain.Entities;
using GarageSoft.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageSoft.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Client, ClientDto>().ReverseMap();
        CreateMap<CreateClientDto, Client>();
    }
}
