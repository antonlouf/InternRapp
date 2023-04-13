using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Common;
using FluentValidation;

namespace backend.Application.Units.Commands.DeleteUnit;
public class DeleteUnitCommandValidator:AbstractValidator<DeleteUnitCommand>
{
    readonly IApplicationDbContext _dbContext;
    public DeleteUnitCommandValidator(IApplicationDbContext dbContext)
    {
        this.CascadeMode = CascadeMode.Stop;
        _dbContext = dbContext;
        var validator = new ValidationFunctions(_dbContext);
        //Not needed
        RuleFor(x => x.Id).GreaterThan(0).MustAsync(validator.CheckIfUnitIdExists).WithMessage("Make sure you are submitting a valid id");
    }


}
