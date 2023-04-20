using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Languages.Common;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Languages.Commands.UpdateLanguage;
public class UpdateLanguageCommandValidator:AbstractValidator<UpdateLanguageCommand>    
{
    private readonly IApplicationDbContext _dbContext;

    public UpdateLanguageCommandValidator(IApplicationDbContext dbContext)
    {
        this.CascadeMode = CascadeMode.Stop;
        _dbContext = dbContext;
        var validator = new Validator(_dbContext);
        RuleFor(x => x).MustAsync(IsUniqueLanguage).NotEmpty().NotNull();
        RuleFor(x => x.Id).NotNull().NotEmpty().MustAsync(validator.DoesIdExists);
        RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("there is already an existing language");
    }

    private async Task<bool> IsUniqueLanguage(UpdateLanguageCommand command, CancellationToken arg2)
    {
        var result = await _dbContext.Languages.Where(x => x.Name == command.Name&&x.Code==command.Code).FirstOrDefaultAsync();
        return result == null;
    }

 

}
