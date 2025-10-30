using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Rimrabic
{
    public static class Validator
    {
        public static bool IsValidRoman(string input)
        {
            // Регулярное выражение для корректных римских чисел от I до MMMCMXCIX
            string pattern = "^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";

            return Regex.IsMatch(input, pattern);
        }
    }
}
