using System;
using System.Linq;
using System.Collections.Generic;
namespace c_sharp
{
    class Program
    {

        static Dictionary<string, Func<double, double, double>> math = new Dictionary<string, Func<double, double, double>>
        {
            {"+", (a, b) => a + b},
            {"-", (a, b) => a - b},
            {"*", (a, b) => a * b},
            {"/", (a, b) => a / b}
        };

        public static double evaluate(String expr) =>
          String.IsNullOrWhiteSpace(expr) ? 0.0 : expr.Split(' ').Aggregate(new Stack<double>(), (stack, op) =>
            {
                var isNumber = Double.TryParse(op, out double number);
                if (isNumber)
                {
                    stack.Push(number);
                }
                else
                {
                    var x = stack.Pop();
                    var y = stack.Pop();
                    var answer = math[op](y, x);
                    stack.Push(answer);
                }
                return stack;
            }).Pop();


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(evaluate("") == 0);
            Console.WriteLine(evaluate("3") == 3);
            Console.WriteLine(evaluate("3.5") == 3.5);
            Console.WriteLine(evaluate("1 3 +") == 4);
            Console.WriteLine(evaluate("1 3 -") == -2);
            Console.WriteLine(evaluate("2 3 *") == 6);
            Console.WriteLine(evaluate("6 3 /") == 2);
            Console.WriteLine(evaluate("5 1 2 + 4 * + 3 -") == 14);
        }
    }
}
