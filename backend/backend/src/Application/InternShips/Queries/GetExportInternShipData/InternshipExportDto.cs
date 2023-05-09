using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.InternShips.Common;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Application.InternShips.Queries.GetInternShipById;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.InternShips.Queries.GetExportInternShipData;

public class InternShipExportDto
{
    public string SchoolYear { get; set; }
    public TrainingType TrainingType { get; set; }
    public IList<LocationDto> Locations { get; set; } //vertalen?

    //public DepartmentDto Department { get; set; } //om op te groupen 
    //dit is rechtstreeks te mappen van Internships -> InternshipsExportDto

    //public InternShipContentTranslation Version { get; set; } //neem hierin de language en map naar TranslationDto
    //public IList<TranslationDto> Translations { get; set; }
    public TranslationDto Translation { get; set; }

    //public void Mapping(Profile profile)
    //{
    //    profile.CreateMap<InternShip, InternShipExportDto>()
    //        .ConvertUsing((source, _, context) =>
    //        {
    //            return new InternShipExportDto
    //            {
    //                SchoolYear = source.SchoolYear,
    //                TrainingType = source.RequiredTrainingType,
    //                Translation = 
    //            };
    //        });
    //}

    //public void Mapping(Profile profile)
    //{
    //    //profile.CreateMap<UnitExportDto, InternShipExportDto>();

    //    profile.CreateMap<InternShip, InternShipExportDto>()
    //       // .ForMember(dest => dest.;
    //    //   .ForMember(pts => pts.PropertyName, opt => opt.MapFrom(ps => ps.Property.PropertyName));
    //    profile.CreateMap<TranslationDto, IList<InternShipContentTranslation>>()
    //}
    //Dit via select of andere mapping 


}