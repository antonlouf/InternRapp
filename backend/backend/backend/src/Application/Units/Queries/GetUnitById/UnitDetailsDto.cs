using AutoMapper;
using backend.Application.ApplicationUsers.Queries.GetById;
using backend.Application.Common.Mappings;
using backend.Domain.Entities;

namespace backend.Application.Units.Queries.GetUnitById;

public class UnitDetailsDto:IMapFrom<Unit>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Unit, UnitDetailsDto>().ForMember(dest=>dest.Id,opt=>opt.MapFrom(src=>src.ApplicationUserId));
    }
}