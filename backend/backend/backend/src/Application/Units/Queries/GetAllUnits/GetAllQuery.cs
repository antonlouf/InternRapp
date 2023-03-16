using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using MediatR;
using Department = backend.Domain.Entities.Department;

namespace backend.Application.Units.Queries.GetAllUnits;
public class GetAllQuery : IRequest<PagedList<UnitListDto>>
{
    public UnitFilterAndPaginationRequestDto Dto { get; set; }
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
        var splittedFilter = request.Dto.Filter.Split(':');
        if (splittedFilter.Length > 1)
        {
            request.Dto.Filter = splittedFilter[1];
        }
        return  await PagedList<UnitListDto>.ToPagedList(_dbContext.Departments.Where(x => x.Name.Contains(request.Dto.Filter)).ProjectTo<UnitListDto>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);
        
    }
}
