using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using MediatR;


namespace backend.Application.Units.Queries.GetAllUnits;
public class GetAllQuery : IRequest<PagedList<UnitListDto>>
{
    public FilterAndPaginationRequestDto Dto { get; set; }
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, PagedList<UnitListDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _iMapper = mapper;
    }

    public async Task<PagedList<UnitListDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var queryable = _dbContext.Departments.AsQueryable();
        if (request.Dto.Filter!=null&&request.Dto.Filter != "")
        {
            var splittedFilter = request.Dto.Filter.Split(':');
            if (splittedFilter.Length > 1)
            {
                queryable = queryable.Where(x => x.Name.StartsWith(splittedFilter[1]));
            }


        }     
        return  await PagedList<UnitListDto>.ToPagedList(queryable.ProjectTo<UnitListDto>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);
        
    }
}
