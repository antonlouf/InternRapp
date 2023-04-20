using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.InternShips.Queries.GetExportInternShipData;
public class InternshipExportDto
{
    public List<int> UnitId { get; set; }
    public List<string> SchoolYear { get; set; }
    public List<int> LanguageId { get; set; }
}
