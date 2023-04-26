using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.BaseContracts;

namespace backend.Application.Common.Paging;
public class UnitFilterAndPaginationDto : IPageable
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public string UnitName { get; set; }
}
