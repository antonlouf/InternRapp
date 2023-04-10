using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.Common.Paging;
public class FilterAndPaginationRequestDto
{
    //Feels like a base class / interface
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    //this filter property can be part of your empty 'getAll queries' -> Way to generic 
    public string Filter { get; set; }
}
