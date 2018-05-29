using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
    class Program
    {

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(w => !b.Contains(w)).ToArray();  
         
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
