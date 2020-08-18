using System;
using System.Linq;

namespace NumberZoo
{
  class Program
  {

    public static int FindNumber(int[] arr)
    {
      // sum the list
      var sum = arr.Sum();
      var n = arr.Length + 1;
      var magic = (n * (n + 1)) / 2;
      return magic - sum;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to C#");
    }
  }
}
