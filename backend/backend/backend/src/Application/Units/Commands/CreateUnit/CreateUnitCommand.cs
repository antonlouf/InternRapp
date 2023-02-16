using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using MediatR;
using Unit= backend.Domain.Entities.Unit;
namespace backend.Application.Units.Commands.CreateUnit;
public class CreateUnitCommand:IRequest
{
    public string Name { get; set; }
    public List<int> SuperVisorIds { get; set; }
}
public class CreateUnitCommandHandler : AsyncRequestHandler<CreateUnitCommand>
{
    private readonly IApplicationDbContext _dbContext;
    public CreateUnitCommandHandler(IApplicationDbContext applicationDbContext)
    {
        _dbContext=applicationDbContext;
    }
    protected async override Task Handle(CreateUnitCommand request, CancellationToken cancellationToken)
    {
        var entityTobeAdded = new Unit() { Name = request.Name};
        entityTobeAdded.ApplicationUser = new();
        // get all users with this id and add to tobeadded
        var queryable=_dbContext.ApplicationUsers.AsQueryable();
        foreach(var id in request.SuperVisorIds) 
        {
            queryable=queryable.Where(x => x.Id == id);
        }
        var result=queryable.ToList();
        entityTobeAdded.ApplicationUser.AddRange(result);
        await _dbContext.Units.AddAsync(entityTobeAdded) ;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
