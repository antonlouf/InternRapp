using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure.Persistence;
public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _applicationDbContext;
    public UnitOfWork(ApplicationDbContext dbContext,IApplicationUserRepistory applicationUsers, IUnitSuperVisorRepository unitSuperVisors, IInternShipRepository internShips, ISubDepartmentRepository subDepartments, IUnitRepository units)
    {
        _applicationDbContext= dbContext;
        ApplicationUsers = applicationUsers;
        UnitSuperVisors = unitSuperVisors;
        InternShips = internShips;
        SubDepartments = subDepartments;
        Units = units;
    }

    public IApplicationUserRepistory ApplicationUsers {get;}

    public IUnitSuperVisorRepository UnitSuperVisors {get;}

    public IInternShipRepository InternShips {get;}

    public ISubDepartmentRepository SubDepartments {get;}

    public IUnitRepository Units {get;}

    public async Task<int> Commit()=>(await _applicationDbContext.SaveChangesAsync());
    
}
