using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Common.Interfaces;
public interface IApplicationDbContext
{
    DbSet<InternShip> InternShips { get; }

    DbSet<ApplicationUser> ApplicationUsers { get; }
    DbSet<SubDepartment> SubDepartments { get; }
    DbSet<Unit> Units { get; }
    DbSet<UnitSuperVisor> UnitSuperVisors { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
