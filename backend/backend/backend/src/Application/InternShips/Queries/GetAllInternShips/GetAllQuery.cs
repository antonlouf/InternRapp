using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Queries.GetAllInternShips;
public class GetAllQuery : IRequest<IEnumerable<InternShipListDto>>
{
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, IEnumerable<InternShipListDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _iMapper;
    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper iMapper)
    {
        _dbContext = dbContext;
        _iMapper = iMapper;
    }

    public async Task<IEnumerable<InternShipListDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var result = await _dbContext.InternShips.ProjectTo<InternShipListDto>(_iMapper.ConfigurationProvider).ToListAsync();
        return result;
    }
}
