using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Locations.Common;
using FluentValidation;

namespace backend.Application.Locations.Commands.DeleteLocation;
public class DeleteLocationCommandValidator: AbstractValidator<DeleteLocationCommand>
{
    private readonly IApplicationDbContext _dbContext;
    public DeleteLocationCommandValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        RuleFor(x => x.Id).NotNull().NotEmpty().MustAsync(new Validator(_dbContext).DoesIdExists).WithMessage("this Id does not exists!!");
    }
}
