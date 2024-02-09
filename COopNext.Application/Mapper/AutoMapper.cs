using AutoMapper;
using COopNext.Application.DTOs;
using COopNext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COopNext.Application.Mapper;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<User, UserDto>()
            .ForMember(d => d.Id, map => map.MapFrom(s => s.Id))
            .ForMember(d => d.Code, map => map.MapFrom(s => s.Code))
            .ForMember(d => d.Name, map => map.MapFrom(s => s.Name))
            .ForMember(d => d.Password, map => map.MapFrom(s => s.Password))
            .ForMember(d => d.IsActive, map => map.MapFrom(s => s.IsActive))
            .ForMember(d => d.Validity, map => map.MapFrom(s => s.Validity))
            .ForMember(d => d.IsLocked, map => map.MapFrom(s => s.IsLocked))
            .ForMember(d => d.RoleId, map => map.MapFrom(s => s.RoleId))
            .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
            .ReverseMap()
            .ForPath(s => s.RowVersion, map => map.Ignore());

        CreateMap<Module, ModuleDto>()
            .ForMember(d => d.Id, map => map.MapFrom(s => s.Id))
            .ForMember(d => d.Name, map => map.MapFrom(s => s.Name))
            .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
            .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
            .ReverseMap()
            .ForPath(s => s.RowVersion, map => map.Ignore());
    }
}
