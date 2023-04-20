using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Commands.CreateUnit;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Common;
public class ValidationFunctions
{
    private readonly IApplicationDbContext _dbContext;

    public ValidationFunctions(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CheckIfUnitIdExists(int arg1, CancellationToken arg2)
    {
        var result = await _dbContext.Departments.SingleOrDefaultAsync(x => x.Id == arg1);
        return result != null;
    }

}
