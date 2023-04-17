using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Infrastructure.Constants;
public static class AppSettingsConstant
{
    public static string InMemoryDB { get; set; } = "UseInMemoryDatabase";
    public static string DefaultInMemoryConnectionString { get; set; } = "Default";
}
