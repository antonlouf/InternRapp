using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using MediatR;

namespace backend.Application.Units.Commands.CreateUnit;
public class CreateUnitCommand:IRequest
{
    public string Name { get; set; }
    public int SuperVisorId { get; set; }
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
        //Dependent of the situation this is true , if by creating a new unit we are going to make the assumption that
        // the supervisor already exists 
        //otherwise we should check if it exists and if not create it before inserting this record
        await _dbContext.Units.AddAsync(new() { Name = request.Name, ApplicationUserId = request.SuperVisorId}) ;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
