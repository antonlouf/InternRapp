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
using backend.Application.Units.Queries.GetAllUnits;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Languages.Queries.GetAllLanguages;
public class GetAllQuery:IRequest<PagedList<LanguageListDto>>
{
    public FilterAndPaginationRequestDto Dto { get; set; }
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, PagedList<LanguageListDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _iMapper = mapper;
    }

    public async Task<PagedList<LanguageListDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var queryable = _dbContext.Languages.AsQueryable().AsNoTracking();
        if (request.Dto.Filter != null && request.Dto.Filter != "")
        {
            var splittedFilter = request.Dto.Filter.Split(':');
            if (splittedFilter.Length > 1)
            {
                queryable = queryable.Where(x => x.Name.StartsWith(splittedFilter[1]));
            }


        }
        return await PagedList<LanguageListDto>.ToPagedList(queryable.ProjectTo<LanguageListDto>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);

    }
}
