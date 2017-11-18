using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detrick.Common.Core
{
    public static class Guard {
    public static void ArgumentIsNotNull(object value, string argument) {
        if (value == null)
            throw new ArgumentNullException(argument);
    }
}

}
