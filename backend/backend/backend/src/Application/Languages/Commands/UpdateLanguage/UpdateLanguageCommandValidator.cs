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
        RuleFor(x => x).NotEmpty().NotNull();
        RuleFor(x => x.Dto.Id).NotNull().NotEmpty().MustAsync(validator.DoesIdExists);
        RuleFor(x => x.Dto.Name).NotNull().NotEmpty().MustAsync(IsNameUnique).WithMessage("there is already an existing language");
    }



    private async Task<bool> IsNameUnique(string langName, CancellationToken arg2)
    {
        //Should be part of the create language too?
        //naming of input
        //Racing condition -> Is name of language part of the DB key? Last resort...
        var result = await _dbContext.Languages.Where(x => x.Name == langName).FirstOrDefaultAsync();
        return result == null;
    }

}
