using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.Units.Queries.GetUnitById;
using backend.Domain.Entities;

namespace backend.Application.Units.Queries.GetAllUnits;

public class UnitListDto : IMapFrom<Unit>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Unit, UnitListDto>();

    }
}