using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningZ.CS.Strings
{
    public static class StringExtensions
    {
        public static string? Left(this string? value, int maxLength)
        {
            if (String.IsNullOrEmpty(value))
            {
                return value;
            }

            return (value.Length <= maxLength
                   ? value
                   : value.Substring(0, maxLength)
                   );
        }
    }
}
