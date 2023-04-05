using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Languages.Common;
public class Validator
{
    private readonly IApplicationDbContext _dbContext;

    public Validator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public  async Task<bool> DoesIdExists(int id,CancellationToken token)
    {
        var result=await _dbContext.Languages.Where(x => x.Id == id).FirstOrDefaultAsync();
        return result != null;

    }
}
