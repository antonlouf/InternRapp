using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Domain.Entities;

namespace backend.Application.InternShips.Queries.GetAllInternShips;
public class TranslationDto : IMapFrom<Translation>
{
    public int Id { get; set; }
    public string TitleContent { get; set; }
    public string Description { get; set; }
    public string KnowledgeToDevelop { get; set; }
    public string NeededKnowledge { get; set; }
    public string Location { get; set; }
    public string Comment { get; set; }
    public string Content { get; set; }
    public Language Language { get; set; }
    public int InternShipId { get; set; }
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Translation, TranslationDto>();

    }
}
