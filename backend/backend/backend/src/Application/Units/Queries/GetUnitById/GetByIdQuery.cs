using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.ApplicationUsers.Queries.GetById;
using backend.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Queries.GetUnitById;
public class GetByIdQuery:IRequest<UnitDetailsDto>
{
    public int Id { get; set; }
}
public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, UnitDetailsDto>
{
    private IApplicationDbContext _dbContext;
    private IMapper _iMapper;
    public GetByIdQueryHandler(IApplicationDbContext applicationDbContext,IMapper mapper)
    {
        _dbContext= applicationDbContext;
        _iMapper= mapper;   
    }
    public async Task<UnitDetailsDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Units.Where(x => x.SupervisorId == request.Id).ProjectTo<UnitDetailsDto>(_iMapper.ConfigurationProvider).FirstOrDefaultAsync(cancellationToken);
    }
}

