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
        RuleFor(x=>x.Name).NotEmpty().NotNull().MinimumLength(2);
        RuleFor(x => x.ManagerEmails).NotNull().NotEmpty();
        RuleFor(x => x.PrefaceTranslations).NotNull().NotEmpty().ForEach(x =>
        {
            x.Must(CheckTranslationIsEmpty);
        });
        RuleFor(x => x.Id).GreaterThan(0).MustAsync(validator.CheckIfUnitIdExists);

    }

    private bool CheckTranslationIsEmpty(PrefaceTranslationUpdateDto translation) => !(String.IsNullOrEmpty(translation.Content));
}
