using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Enums;
    //https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
public enum TrainingType
{
    Bachelor,
    Master,
    MasterAfterMaster,
    MasterAfterBachelor
}
