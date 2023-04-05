﻿using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Common;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.InternShips.Queries.GetAllInternShips;

public class InternShipListDto:IMapFrom<InternShip>
{
    public string SchoolYear { get; set; }
    public int InternShipId { get; set; }
    public DepartmentDto Unit { get; set; }
    public byte MaxCountOfStudents { get; set; }
    public byte CurrentCountOfStudents { get; set; }
    public TrainingType TrainingType { get; set; }

    public LocationDto Location { get; set; }
    public IList<TranslationDto> Versions { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<InternShip, InternShipListDto>()
                    .ForMember(dest => dest.InternShipId, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.MaxCountOfStudents, opt => opt.MapFrom(src => src.MaxStudents))
                    .ForMember(dest => dest.Versions, opt => opt.MapFrom(src => src.Translations));


    }
}