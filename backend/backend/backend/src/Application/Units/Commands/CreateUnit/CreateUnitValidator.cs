using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Commands.CreateUnit;
public class CreateUnitValidator:AbstractValidator<CreateUnitCommand>
{
    private readonly IApplicationDbContext _dbContext;
    public CreateUnitValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext; 
        RuleFor(x => x.SuperVisorId).NotEmpty().NotNull().GreaterThan(0).MustAsync(ValidSupervisorId).WithMessage("Make sure you are giving an valid id");
        RuleFor(x => x.Name).NotEmpty().NotNull().MaximumLength(100).Must(CheckDepartmentName).WithMessage("Make sure you are giving a valid unit name");
    }

    private bool CheckDepartmentName(string arg)
    {
        string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        foreach (var item in specialChar)
        {
            if (arg.Contains(item)) return false;
        }

        return true;
    }

    private async Task<bool> ValidSupervisorId(int id, CancellationToken arg2)
    {
        //this should later be replaced with mediator so the responsible handler is going call it instead this validator
       return (await _dbContext.UnitSuperVisors.Where(x => x.Id == id).FirstOrDefaultAsync()!=null);
    }
}
