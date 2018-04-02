using System;
using System.Linq;

namespace c_sharp
{
    class Program
    {
        public static int Test(string numbers)
        {
            var sorted = numbers
                          .Split(' ')
                          .Select(Int32.Parse)
                          .Select((s, i) => new { isEven = s % 2 == 0, item = s, index = i });
            var even = sorted.Where(c => c.isEven);
            var odd = sorted.Where(c => !c.isEven);
            if (even.Count() == 1)
            {
                return even.First().index + 1;
            }
            else
            {
                return odd.First().index + 1;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
