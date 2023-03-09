using AutoMapper;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using MediatR;
using Unit = backend.Domain.Entities.Unit;

namespace backend.Application.Units.Queries.GetAllUnits;
public class GetAllQuery : IRequest<UnitFilterAndPaginationResponseDto<Unit>>
{
    public UnitFilterAndPaginationRequestDto Dto { get; set; }
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, UnitFilterAndPaginationResponseDto<Unit>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _iMapper = mapper;
    }

    public async Task<UnitFilterAndPaginationResponseDto<Unit>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var result = await PagedList<Unit>.ToPagedList(_dbContext.Units.Where(x => x.Name.Contains(request.Dto.Filter)), request.Dto.PageIndex, request.Dto.PageSize);
        
        return new() { TotalCount=result.TotalCount,Items=result};
    }
}
