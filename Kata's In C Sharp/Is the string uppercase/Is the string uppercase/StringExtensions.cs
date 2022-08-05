using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_string_uppercase
{
    internal static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            return text == text.ToUpper() ? true : false; 
        }
    }
}
