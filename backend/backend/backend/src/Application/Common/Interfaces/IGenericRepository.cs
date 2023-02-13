using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.Common.Interfaces;
public interface IGenericRepository<T> where T: class
{
    IEnumerable<T> GetAll();
    T GeTtById(object id);
    T Insert(T obj);
    T Update(T obj);
    void Delete(object id);
    void Save();
}
