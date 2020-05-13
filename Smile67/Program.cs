using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Smile67
{
  class Program
  {

    public class Data
    {
      public string Left { get; set; }
      public string Right { get; set; }
      public char? Operator { get; set; } = null;
      public string GetIt()
      {
        var l = double.Parse(this.Left);
        var r = double.Parse(this.Right);
        Console.WriteLine($"{this.Left} {this.Operator} {this.Right}");
        var rv = 0d;
        switch (Operator)
        {
          case '*':
            rv = l * r;
            break;
          case '+':
            rv = l + r;
            break;
          case '-':
            rv = l - r;
            break;
          case '/':
            rv = l / r;
            break;
          default:
            rv = 0;
            break;
        }
        return Math.Round(rv).ToString();
      }
    }

    public static string CalculateString(string calcIt)
    {
      return calcIt.Aggregate(new Data(), (acc, letter) =>
      {
        if (Char.IsDigit(letter) || letter == '.')
        {
          if (acc.Operator != null)
          {
            acc.Right += letter;

          }
          else
          {
            acc.Left += letter;
          }
        }
        else if ("*+-/".Contains(letter))
        {
          acc.Operator = letter;
        }
        return acc;
      }).GetIt();
    }

    static void Main(string[] args)
    {
      Console.WriteLine(CalculateString("fsdfsd234.4554s4234df+sf234442"));
    }
  }
}
