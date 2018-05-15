using System;
using System.Linq;

namespace c_sharp
{
    class Program
    {

        public static int DuplicateCount(string str)
        {
            return str.ToLower().Distinct().ToDictionary(k => k, v => str.Count(c => v == c)).Count(w => w.Value >= 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
