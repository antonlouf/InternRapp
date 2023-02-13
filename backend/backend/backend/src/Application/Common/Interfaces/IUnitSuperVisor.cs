using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;

namespace backend.Application.Common.Interfaces;
public interface IUnitSuperVisor:IGenericRepository<UnitSuperVisor>
{
    UnitSuperVisor GetByFilter(Func<InternShip, bool> predicate);   
}
