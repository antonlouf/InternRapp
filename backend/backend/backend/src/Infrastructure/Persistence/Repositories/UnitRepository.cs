using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure.Persistence.Repositories;
public class UnitRepository : GenericRepository<Unit>, IUnitRepository
{
    
    public UnitRepository(ApplicationDbContext context) : base(context)
    {
       
    }

    public List<Unit> GetByFilter(Expression<Func<Unit, bool>> predicate)
    {
        var queryable = _dataSet.AsQueryable();
        queryable = queryable.Where(predicate);
        return queryable.ToList();

    }
}
