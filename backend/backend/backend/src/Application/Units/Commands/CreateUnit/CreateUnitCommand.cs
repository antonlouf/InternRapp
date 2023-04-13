using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using MediatR;

namespace backend.Application.Units.Commands.CreateUnit;
public class CreateUnitCommand:IRequest
{
    public string Name { get; init; }
    public List<string> SuperVisorEmails { get; init; }
}
//multiple files
//Immutable command
public class CreateUnitCommandHandler : AsyncRequestHandler<CreateUnitCommand>
{
    private readonly IApplicationDbContext _dbContext;
    public CreateUnitCommandHandler(IApplicationDbContext applicationDbContext)
    {
        _dbContext=applicationDbContext;
    }
    protected async override Task Handle(CreateUnitCommand request, CancellationToken cancellationToken)
    {
        var entityTobeAdded = new Department() { Name = request.Name,ManagerEmails=request.SuperVisorEmails};    
        await _dbContext.Departments.AddAsync(entityTobeAdded) ;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
