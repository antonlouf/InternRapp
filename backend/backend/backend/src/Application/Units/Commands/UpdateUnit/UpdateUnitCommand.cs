using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit= backend.Domain.Entities.Department;
using MediatR;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Queries.GetUnitById;
using Microsoft.EntityFrameworkCore;
using backend.Application.Units.Queries.GetAllUnits;

namespace backend.Application.Units.Commands.UpdateUnit;
public class UpdateUnitCommand:IRequest
{
    public UnitListDto Unit { get; set; }
}
public class UpdateUnitCommandHandler : AsyncRequestHandler<UpdateUnitCommand>
{

    private readonly IApplicationDbContext _dbContext;
    public UpdateUnitCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected async override Task Handle(UpdateUnitCommand request, CancellationToken cancellationToken)
    {
        //add control to the validator to check there is an existing item with this id!!
        var unit = await _dbContext.Departments.FirstOrDefaultAsync(x=>x.Id==request.Unit.Id);
        unit.Name= request.Unit.Name; 
        unit.ManagerEmails=request.Unit.ManagerEmails;
        _dbContext.Departments.Update(unit);
       await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
