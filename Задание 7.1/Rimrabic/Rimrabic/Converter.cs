using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rimrabic
{
    public static class Converter
    {

        private static readonly Dictionary<char, int> RomanValues = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };

        private static readonly Dictionary<int, string> ArabicToRomanMap = new Dictionary<int, string>
        {
            {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
            {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
            {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
        };
       
        public static int RomanToArabic(string roman)
        {
            int total = 0;
            int prevValue = 0;

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int value = RomanValues[roman[i]];
                if (value < prevValue)
                    total -= value;
                else
                    total += value;
                prevValue = value;
            }

            return total;
        }

        public static string ArabicToRoman(int number)
        {
            var result = "";
            foreach (var pair in ArabicToRomanMap)
            {
                while (number >= pair.Key)
                {
                    result += pair.Value;
                    number -= pair.Key;
                }
            }
            return result;
        }
    }

}
