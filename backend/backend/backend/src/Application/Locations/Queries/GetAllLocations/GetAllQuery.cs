using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using backend.Application.InternShips.Common;
using MediatR;

namespace backend.Application.Locations.Queries.GetAllLocations;
public class GetAllQuery:IRequest<PagedList<LocationDto>> 
{
    public FilterAndPaginationRequestDto Dto { get; set; }
}

public class getAllQueryHandler : IRequestHandler<GetAllQuery, PagedList<LocationDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public getAllQueryHandler(IApplicationDbContext dbContext, IMapper iMapper)
    {
        _dbContext = dbContext;
        _iMapper = iMapper;
    }

    public async Task<PagedList<LocationDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var queryable = _dbContext.Locations.AsQueryable();
        if (request.Dto.Filter != null && request.Dto.Filter != "")
        {
            var splittedFilter = request.Dto.Filter.Split(':');
            if (splittedFilter.Length > 1)
            {
                queryable = queryable.Where(x => x.City.StartsWith(splittedFilter[1]));
            }

        }
        return await PagedList<LocationDto>.ToPagedList(queryable.ProjectTo<LocationDto>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);
    }
}
