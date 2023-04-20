using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Common;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Queries.GetUnitById;
public class GetByIdQueryValidator:AbstractValidator<GetByIdQuery>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMediator _mediator;
    public GetByIdQueryValidator(IApplicationDbContext dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
        var validator = new ValidationFunctions(_dbContext);
        RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0).MustAsync(CheckUnitIdExists).WithMessage("Make sure you are giving an existing ID!(also greater than 0)");
    }

    private async Task<bool> CheckUnitIdExists(int arg1, CancellationToken arg2)
    {
        var result= await _dbContext.Departments.FirstOrDefaultAsync(x=>x.Id== arg1);
        return result!=null;
    }
}
