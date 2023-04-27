using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.InternShips.Common;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.InternShips.Queries.GetExportInternShipData;

public class InternShipExportDto
{
    public string SchoolYear { get; set; }
    public TrainingType TrainingType { get; set; }
    public LocationDto Location { get; set; } //vertalen?
    public DepartmentDto Department { get; set; } //om op te groupen 
    //dit is rechtstreeks te mappen van Internships -> InternshipsExportDto

    public InternShipContentTranslation Version { get; set; } //neem hierin de language en map naar TranslationDto
    public TranslationDto Translation { get; set; }
    //Dit via select of andere mapping 

    public void Mapping(Profile profile)
    {
        profile.CreateMap<InternShip, InternShipExportDto>()
            .ForMember(dest => dest.Department.Id, opt => opt.MapFrom(src => src.Unit.Id));
        //profile.CreateMap<InternShipContentTranslation, InternShipExportDto>();
    }
}