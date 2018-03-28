using System;
using System.Linq;
using System.Collections.Generic;
namespace c_sharp
{
    class Program
    {

        public static void display(IEnumerable<int> arr){
            Console.WriteLine("----");
            if (arr == null) return;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] Divisors(int n)
        {
            var rv = Enumerable.Range(2, n/2).ToArray().Where(w => n % w == 0).ToArray();
            return rv.Length == 0 ? null : rv;
        }

        public static int[] Divisors(int n)
        {
            var rv = new List<int>();
            var top = n/2;
            for (int i = 0; i < n; i++)
            {
                if (n % 1 == 0){
                    rv.Add(i);
                }
            }
            
            return rv.Count() == 0 ? null : rv.ToArray();
        }

        static void Main(string[] args)
        {
          display(Divisors(12));
          display(Divisors(25));
          display(Divisors(13));
          display(Divisors(24));
            
        }
    }
}
