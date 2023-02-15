﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit= backend.Domain.Entities.Unit;
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
    private readonly IMediator _mediator;
    public UpdateUnitCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
    }

    protected async override Task Handle(UpdateUnitCommand request, CancellationToken cancellationToken)
    {
        //add control to the validator to check there is an existing item with this id!!
        var unit = await _dbContext.Units.Where(x => x.Id == request.Unit.Id).FirstOrDefaultAsync();
        unit.Name= request.Unit.Name;   
        _dbContext.Units.Update(unit);
       await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
