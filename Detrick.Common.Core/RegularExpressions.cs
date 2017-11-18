using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detrick.Common.Core
{
    using System.Text.RegularExpressions;

    public class RegularExpressions
    {
        public static bool  EmailAddressValidation(string val)
        {
            return Regex.IsMatch(val, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static bool PhoneNumberValidation(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, "(1-)?\\p{N}{3}-\\p{N}{3}-\\p{N}{4}\\b");
        }
    }
}
