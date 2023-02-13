using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;

namespace backend.Infrastructure.Persistence.Repositories;
public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepistory
{

    public ApplicationUserRepository(ApplicationDbContext context) : base(context)
    {
    }

    public List<ApplicationUser> GetByFilter(Expression<Func<ApplicationUser, bool>> predicate)
    {
        var queryable = _dataSet.AsQueryable();
        queryable = queryable.Where(predicate);
        return queryable.ToList();
    }
}
