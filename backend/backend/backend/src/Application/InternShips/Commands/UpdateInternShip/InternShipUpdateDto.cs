using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Domain.Enums;

namespace backend.Application.InternShips.Commands.UpdateInternShip;
public class InternShipUpdateDto
{
    public int internShipId { get; set; }
    public string SchoolYear { get; set; }
    public int UnitId { get; set; }
    public byte MaxCountOfStudents { get; set; }
    public TrainingType TrainingType { get; set; }
    public byte CurrentCountOfStudents { get; set; }


    public int LocationId { get; set; }
    public IList<LanguageSpecificUpdateInternShipDto> Versions { get; set; }
}
