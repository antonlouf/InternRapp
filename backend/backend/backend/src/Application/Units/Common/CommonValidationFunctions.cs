using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Units.Common;
public  class CommonValidationFunctions
{
    private IApplicationDbContext _dbContext;
    public CommonValidationFunctions(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async  Task<bool> CheckIfIdExists(int id)
    {
        return (await _dbContext.UnitSuperVisors.Where(x => x.Id == id).FirstOrDefaultAsync() != null);

    }
}
