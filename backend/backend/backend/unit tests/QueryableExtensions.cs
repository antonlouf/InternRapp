 using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace unit_tests;
public static class QueryableExtensions
{
    public static async Task<T> FirstOrDefaultAsync<T>(this IQueryable<T> queryable, Expression<Func<T, bool>> predicate)
    {
        return await Task.FromResult(queryable.FirstOrDefault(predicate));
    }
}
