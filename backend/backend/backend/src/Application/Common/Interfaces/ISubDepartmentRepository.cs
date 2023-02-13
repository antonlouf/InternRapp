using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;

namespace backend.Application.Common.Interfaces;
public interface ISubDepartmentRepository:IGenericRepository<SubDepartment>
{
    SubDepartment GetByFilter(Func<InternShip, bool> predicate);

}
