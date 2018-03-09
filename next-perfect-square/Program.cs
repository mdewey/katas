using System;

namespace next_perfect_square
{
    class Program
    {

        public static long FindNextSquare(long num)
        {
            // your code here
            var root = Math.Sqrt((double)num);
            if (root == Math.Floor(root)){
                return (long) Math.Pow(++root, 2);
            } else {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
