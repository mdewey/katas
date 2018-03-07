using System;
using System.Linq;

namespace bit_counting
{
    class Program
    {

        public static int CountBits(int n)
        {
            var binary = Convert.ToString(n, 2);
            var count = binary.Count(c => c == '1');
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
