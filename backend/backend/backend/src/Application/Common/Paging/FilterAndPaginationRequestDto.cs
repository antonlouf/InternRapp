﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.Common.Paging;
public class FilterAndPaginationRequestDto: BasePagination
{
    
    //this filter property can be part of your empty 'getAll queries' -> Way to generic 
    public string Filter { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
}
