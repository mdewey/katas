using System;
using System.Linq;


namespace c_sharp
{
    class Program
    {
        static Func<char, int> convertCharToInt = (ch) => (int)(ch - '0');
        static Func<int, int> convertToScore = (letter) => letter - 48;
        static Func<char, int> convertCharToScore = (ch) => convertToScore(convertCharToInt(ch));
        public class Kata
        {
            public static string High(string s)
            {
                var highest = s
                 .ToLower()
                 .Split(' ')
                 .Select(word => new { word, score = word.Sum(convertCharToScore) })
                 .OrderByDescending(o => o.score).First().word;
                System.Console.WriteLine(highest);
                return highest;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Kata.High("man i need a taxi up to ubud"));
        }
    }
}
