using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.InternShips.Commands.CreateInternShip;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Common.ValidationFunctions;
public static class ValidationFunctions
{
    public static bool IsStringWithoutSpecialChars(this string arg)
    {
        string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        foreach (var item in specialChar)
        {
            if (arg.Contains(item)) return false;
        }

        return true;
    }
}
