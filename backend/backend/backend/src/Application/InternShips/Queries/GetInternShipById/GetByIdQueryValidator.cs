using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Models;
using backend.Application.InternShips.Common;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Queries.GetInternShipById;
public class GetByIdQueryValidator:AbstractValidator<GetByIdQuery>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMediator _mediator;

    public GetByIdQueryValidator(IApplicationDbContext dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
        var validator = new ValidationFunctions( _dbContext);
        //dont expose internal workings
        //not sure if we need to validate a query? Internal DB workings are exposed / Id is a int (impossible to be null/empty)
        RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0).MustAsync(validator.CheckIfInternShipIdExists).WithMessage("Make sure you are giving an existing ID!(also greater than 0)");

    }


}
