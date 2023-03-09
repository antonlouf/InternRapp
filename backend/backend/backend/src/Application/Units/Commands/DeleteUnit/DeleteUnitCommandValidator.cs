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
        _dbContext = dbContext;
        RuleFor(x => x.Id).NotNull().NotEmpty().GreaterThan(0).MustAsync(CheckIfIdExists).WithMessage("Make sure you are submitting a valid id");
    }

    private async Task<bool> CheckIfIdExists(int id, CancellationToken arg2)
    {
        var validator = new CommonValidationFunctions(_dbContext);
       return await validator.CheckIfIdExists(id);
      
    }
}
