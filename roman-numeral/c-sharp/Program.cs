using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
    class Program
    {
        public static Dictionary<string, int> ConversionTable = new Dictionary<string, int>{
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000},
            {"IV", 4},
            {"IX", 9},
            {"XL", 40},
            {"XC", 90},
            {"CD", 400},
            {"CM", 900},
        };

        
        public static int Solution(string roman)
        {
            var rv = 0;
            roman += " ";
            Console.WriteLine(new {roman});
            for (int i = 0; i < roman.Length-1; i++)
            {
                var letter = roman[i];
                var maybeCombo = $"{letter}{roman[i+1]}".Trim();
                if (ConversionTable.ContainsKey(maybeCombo)){
                    rv += ConversionTable[maybeCombo];
                    i++;
                } else {
                    rv += ConversionTable[letter.ToString()];
                }
            }
            return rv;
        }
        static void Main(string[] args)
        {
           Console.WriteLine(Solution("I"));
           Console.WriteLine(Solution("M"));
           Console.WriteLine(Solution("II"));
           Console.WriteLine(Solution("MCMXC"));
        }
    }
}
