using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Common;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.InternShips.Queries.GetAllInternShips;

public class InternShipListDto:IMapFrom<InternShip>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string UnitName { get; set; }
    public int MaxStudents { get; set; }
    public int CurrentCountOfStudents { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<InternShip, InternShipListDto>()
            .ForMember(x => x.UnitName, opt => opt.MapFrom(src => src.Unit.Name))
            .ForMember(x => x.Title, opt => opt.MapFrom(src => src.Translations.FirstOrDefault().TitleContent));
              


    }
}