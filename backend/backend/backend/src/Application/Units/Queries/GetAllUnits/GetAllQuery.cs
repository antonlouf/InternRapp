using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit= backend.Domain.Entities.Unit;
using MediatR;
using backend.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using backend.Application.Units.Queries.GetUnitById;
using AutoMapper.QueryableExtensions;

namespace backend.Application.Units.Queries.GetAllUnits;
public class GetAllQuery:IRequest<IEnumerable<UnitListDto>>
{
   
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, IEnumerable<UnitListDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _iMapper = mapper;
    }

    public async Task<IEnumerable<UnitListDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        return (await _dbContext.Units.ProjectTo<UnitListDto>(_iMapper.ConfigurationProvider).ToListAsync());
    }
}
