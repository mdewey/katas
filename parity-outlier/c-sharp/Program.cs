using System;
using System.Linq;
using System.Collections.Generic;


namespace c_sharp
{
    public class Kata
    {
        // testst he first three to find the pattern, 
        public static int Find_v2(IList<int> integers)
        {
            Func<int, bool> isOdd = i => i % 2 !=0;
            Func<int, bool> isEven = i => i % 2 ==0;
            // test the first three, 
            // query for the one that isnt in the first three
            var test = new List<int> { integers[0], integers[1], integers[2] };
            var oddCount = test.Count(isOdd);
            // check if the pattern is odd
            if (oddCount >= 2)
            {
                // return the first even
                return integers.First(isEven);
            }
            else
            {
                // pattern is even
                // return the first odd
                return integers.First(isOdd);
            }


        }


        // Runtime of O(n)
        // Space of 1
        public static int Find_v1(IList<int> integers)
        {
            var countOfOdd = 0;
            var countOfEvent = 0;
            var total = 0;
            var lastOdd = 0;
            var lastEven = 0;
            foreach (var num in integers)
            {
                total++;
                if (num % 2 == 0)
                {
                    countOfEvent++;
                    lastEven = num;
                }
                else
                {
                    countOfOdd++;
                    lastOdd = num;
                }
            }
            if (countOfEvent == 1)
            {
                return lastEven;
            }
            else
            {
                return lastOdd;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
