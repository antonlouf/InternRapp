using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using backend.Application.Units.Queries.GetAllUnits;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Queries.GetAllUnitsWithMinimalInfo;
public class GetAllQuery:IRequest<PagedList<UnitListDtoWithMinimalData>>
{
    public FilterAndPaginationRequestDto Dto { get; set; }
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery,PagedList<UnitListDtoWithMinimalData>>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _iMapper;
    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper iMapper)
    {
        _dbContext = dbContext;
        _iMapper = iMapper;
    }

    public async Task<PagedList<UnitListDtoWithMinimalData>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var queryable = _dbContext.Departments.AsQueryable();
        if (request.Dto.Filter != null && request.Dto.Filter != "")
        {
            var splittedFilter = request.Dto.Filter.Split(':');
            if (splittedFilter.Length > 1)
            {
                queryable = queryable.Where(x => x.Name.StartsWith(splittedFilter[1]));
            }


        }
        return await PagedList<UnitListDtoWithMinimalData>.ToPagedList(queryable.ProjectTo<UnitListDtoWithMinimalData>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);

    }
}
