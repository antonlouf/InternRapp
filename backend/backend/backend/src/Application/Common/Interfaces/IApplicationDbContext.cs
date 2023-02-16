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
    DbSet<Unit> Units { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
