using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure.Persistence.Repositories;
public class GenericRepository<T>  : IGenericRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dataSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dataSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dataSet.Add(entity);
    }
    public void AddRange(IEnumerable<T> entities)
    {
        _dataSet.AddRange(entities);
    }
    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _dataSet.Where(expression);
    }
    public IEnumerable<T> GetAll()
    {
        return _dataSet.ToList();
    }

    public List<T> GetByFilter(Expression<Func<T, bool>> predicate)
    {
        var queryable = _dataSet.AsQueryable();
        queryable = queryable.Where(predicate);
        return queryable.ToList();
    }

    public T? GetById(int id)
    {
        return _dataSet.Find(id);
    }
    public void Remove(T entity)
    {
        _dataSet.Remove(entity);
    }
    public void RemoveRange(IEnumerable<T> entities)
    {
        _dataSet.RemoveRange(entities);
    }
}
