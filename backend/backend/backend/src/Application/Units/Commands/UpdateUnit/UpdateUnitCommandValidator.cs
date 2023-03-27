using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Common;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Commands.UpdateUnit;
public class UpdateUnitCommandValidator:AbstractValidator<UpdateUnitCommand>
{
    private readonly IApplicationDbContext _dbContext;


    public UpdateUnitCommandValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        this.CascadeMode = CascadeMode.Stop;
        var validator = new ValidationFunctions(_dbContext);
        RuleFor(x=>x.Unit.Name).NotEmpty().NotNull().MinimumLength(2);
        RuleFor(x => x.Unit.Id).NotNull().NotEmpty().GreaterThan(0).MustAsync(validator.CheckIfUnitIdExists);

    }



 
}
