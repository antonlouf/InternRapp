using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using backend.Application.InternShips.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Queries.GetAllInternShips;
public class GetAllQuery : IRequest<PagedList<InternShipDto>>
{
    public FilterAndPaginationRequestDto Dto { get; set; }
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, PagedList<InternShipDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _iMapper;
    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper iMapper)
    {
        _dbContext = dbContext;
        _iMapper = iMapper;
    }

    public async Task<PagedList<InternShipDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        // later to be adjusted to filter year unit 
        var queryable = _dbContext.InternShips.AsQueryable();
        if (request.Dto.Filter != null && request.Dto.Filter != "")
        {
            var splittedFilter = request.Dto.Filter.Split(':');
            if (splittedFilter.Length > 1)
            {
                queryable = queryable.Where(x => x.SchoolYear.StartsWith(splittedFilter[1]));
            }


        }
        return await PagedList<InternShipDto>.ToPagedList(queryable.ProjectTo<InternShipDto>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);
    }
}
