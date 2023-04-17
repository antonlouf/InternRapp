using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittesten
{
    public class DepartmentUnitTests
    {
        [Fact]
        public void Empty_Name_Should_Throw_Error()
        {
            var validator = new CreateUnitValidator();
        }
    }
}
