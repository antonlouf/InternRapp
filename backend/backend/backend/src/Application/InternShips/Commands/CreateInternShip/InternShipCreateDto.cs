using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.InternShips.Commands.CreateInternShip;

public class InternShipCreateDto
{
    public string SchoolYear { get; set; }
    public int UnitId { get; set; }
    public byte MaxCountOfStudents { get; set; }
    public TrainingType TrainingType { get; set; }

    public int LocationId { get; set; }
    public IList<LanguageSpecificInternShipDto> Versions { get; set; }


}