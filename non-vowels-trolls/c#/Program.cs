using System;
using System.Linq;

namespace non_vowels_trolls
{
    class Program
    {
        public static string Disemvowel(string str)
        {
            var _rv = String.Join("", str.Where(s => !"aeiouAEIOU".Contains(s)));
            return _rv;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
