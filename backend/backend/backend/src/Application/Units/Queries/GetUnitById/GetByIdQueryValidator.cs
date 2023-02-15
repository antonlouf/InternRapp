using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Queries.GetUnitById;
public class GetByIdQueryValidator:AbstractValidator<GetByIdQuery>
{
    private readonly IApplicationDbContext _dbContext;
    public GetByIdQueryValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0).MustAsync(CheckIdIsExisting).WithMessage("Make sure you are giving an existing ID!(also greater than 0)").MustAsync(CheckIdIsExisting);

    }

    private async Task<bool> CheckIdIsExisting(int arg1, CancellationToken arg2)
    {
        return await _dbContext.Units.Where(x => x.Id==arg1).FirstOrDefaultAsync() != null;
    }
}
