﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Common.ValidationFunctions;
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
    }

    public UpdateUnitCommandValidator()
    {
        RuleFor(x=>x.Unit.Name).NotEmpty().NotNull().MinimumLength(2).Must(CheckName);
        RuleFor(x => x.Unit.Id).NotNull().NotEmpty().GreaterThan(0).MustAsync(CheckIfIdExists);

    }

    private async Task<bool> CheckIfIdExists(int id, CancellationToken arg2)
    {
        var validator = new CommonValidationFunctions(_dbContext);
        return await validator.CheckIfIdExists(id);
    }

    private bool CheckName(string arg) => arg.IsStringWithoutSpecialChars();
 
}