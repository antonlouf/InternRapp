using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.Common.Interfaces;
public interface IApplicationUserRepistory:IGenericRepository<ApplicationUser>
{

}
