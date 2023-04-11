using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Queries.GetInternShipById;
public class GetByIdQuery:IRequest<InternShip>
{
    public int Id { get; set; }
}
public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, InternShip>
{
    private readonly IApplicationDbContext _dbContext;

    public GetByIdQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<InternShip> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.InternShips.FirstOrDefaultAsync(x=>x.Id== request.Id); 
    }
}
