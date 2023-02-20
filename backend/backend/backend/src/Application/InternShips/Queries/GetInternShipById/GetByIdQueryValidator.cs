using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Common.ValidationFunctions;
using FluentValidation;
using MediatR;

namespace backend.Application.InternShips.Queries.GetInternShipById;
public class GetByIdQueryValidator:AbstractValidator<GetByIdQuery>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMediator _mediator;

    public GetByIdQueryValidator(IApplicationDbContext dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
        var validator = new ValidationFunctionIdChecking(_mediator, _dbContext);
        RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0).MustAsync(validator.CheckIfInternShipIdExists).WithMessage("Make sure you are giving an existing ID!(also greater than 0)");

    }
}
