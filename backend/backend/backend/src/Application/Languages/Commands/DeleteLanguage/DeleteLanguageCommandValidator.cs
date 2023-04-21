using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Languages.Common;
using FluentValidation;

namespace backend.Application.Languages.Commands.DeleteLanguage;
public class DeleteLanguageCommandValidator:AbstractValidator<DeleteLanguageCommand>
{
    private readonly IApplicationDbContext _dbContext;
    public DeleteLanguageCommandValidator(IApplicationDbContext dbContext)
    {
        //Id cannot be null / empty 
        //This is a good example for my opinion on DB calls inside this validation pipeline -> We are doing 2 calls here (get and the real delete)
        //Do we even want to validate if this id exists on a delete? 
        _dbContext = dbContext;
        RuleFor(x => x.Id).NotNull().NotEmpty().MustAsync(new Validator(_dbContext).DoesIdExists).WithMessage("invalid id");
    }
}
