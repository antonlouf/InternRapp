using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.Units.Queries.GetAllUnits;
public class UnitFilterAndPaginationRequestDto
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public string  Filter { get; set; }
}
