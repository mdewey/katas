using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
    class Program
    {

        public class Interpreter
        {
            private List<int> _memory = new List<int>();
            // Commands

            private Dictionary<char, Action> commands = new Dictionary<char, Action>{
                // >: Move data selector right
                {'>', () => {Console.WriteLine("Excecuting >");}},

                // <: Move data selector left(infinite in both directions)
                {'<', () => {Console.WriteLine("Excecuting <");}},

                // +: Increment memory cell by 1. 255+1=0
                {'+', () => {Console.WriteLine("Excecuting +");}},

                // *: Add ascii value of memory cell to the output tape.
                {'*', () => {Console.WriteLine("Excecuting *");}},
            };

            public void ProcessCommand(char command) => this.commands[command]();
        }

        public class Ticker
        {
            public static string Interpret(string tape)
            {
                var processor = new Interpreter();
                tape.ToList().ForEach(command => {
                    processor.ProcessCommand(command);
                });
                return tape;
            }
        }

        static void Main(string[] args)
        {
            var helloWorld = "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++**>+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>++++++++++++++++++++++++++++++++*>+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*<<*>>>++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*<<<<*>>>>>++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>+++++++++++++++++++++++++++++++++*";
            Console.WriteLine(Ticker.Interpret(helloWorld));
            Console.WriteLine("Hello World!");
        }
    }
}
