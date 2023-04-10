using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Commands.DeleteUnit;
public class DeleteUnitCommand:IRequest
{
    public int Id { get; set; }

}
//different files
public class DeleteUnitCommandHandler : AsyncRequestHandler<DeleteUnitCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public DeleteUnitCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

  
    protected async override Task Handle(DeleteUnitCommand request, CancellationToken cancellationToken)
    {
        //single or default (or find)
        var entityTobeDeleted=await _dbContext.Departments.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
        _dbContext.Departments.Remove(entityTobeDeleted);
        await _dbContext.SaveChangesAsync(cancellationToken);
        
    }
}
