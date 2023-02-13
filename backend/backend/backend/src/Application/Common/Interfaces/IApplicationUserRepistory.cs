using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.Common.Interfaces;
public interface IApplicationUserRepistory:IGenericRepository<ApplicationUser>
{
    ApplicationUser GetByFilter(Func<InternShip, bool> predicate);

}
