using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Common.Interfaces;
public interface IUnitOfWork
{
    public IApplicationUserRepistory ApplicationUsers { get; }
    public IUnitSuperVisorRepository UnitSuperVisors { get; }
    public IInternShipRepository InternShips { get; }
    public ISubDepartmentRepository SubDepartments { get; }
    public IUnitRepository Units { get; }
    Task<int> Commit();

}
