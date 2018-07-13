using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
    class Program
    {
        public class Kata
        {
            public static string[] KillCount(Dictionary<string, int> counselors, int jason)
            {
                return counselors.Where(person => person.Value < jason).Select(s => s.Key).ToArray();
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> counselors = new Dictionary<string, int>
            {
                {"Mike", 7},
                {"Alysa", 3}
            };
            Console.WriteLine(Kata.KillCount(counselors, 7));
        }
    }
}
