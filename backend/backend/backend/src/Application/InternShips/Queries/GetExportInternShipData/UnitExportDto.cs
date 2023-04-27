using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.InternShips.Common;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Domain.Entities;
using backend.Domain.Enums;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace backend.Application.InternShips.Queries.GetExportInternShipData;
public class UnitExportDto //unitListDTO met bijbehorende internships  
{
    //public int DepartmentId { get; set; }   
    //public DepartmentDto Unit { get; set; } 
    //public List<int> InternShipId { get; set; } 

    public string Name { get; set; }

    public IEnumerable<InternShipExportDto> InternShips { get; set; }

    //Mapper.CreateMap<IGrouping<PlayerWar, Score>, PlayerWarScore>
    //.ForMember(model => model.PlayerName, model => model.MapFrom(grouping => grouping.Key.Player.Name))
    //.ForMember(model => model.WarName, model => model.MapFrom(grouping => grouping.Key.War.Name)),
    //.ForMember(model => model.Score, model => model.MapFrom(grouping => grouping.Sum(score => score.Score));

    public void Mapping(Profile profile)
    {
        //profile.CreateMap<IEnumerable<InternShip>, UnitExportDto>()
        //    .ForMember(dest => dest.Unit.Id, opt => opt.MapFrom(src => src.Select(x => x.UnitId)));
    }

}
