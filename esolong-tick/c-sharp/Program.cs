using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
    class Program
    {

        public class Interpreter
        {
            // <address, value>
            private Dictionary<int, int> _memory = new Dictionary<int, int>();
            private int _dataSelector = 0;
            private List<char> _tape = new List<char>();
            // Commands
            private Dictionary<char, Action> commands;

            public Interpreter()
            {
                commands = new Dictionary<char, Action>{
                // >: Move data selector right
                {'>', () => {
                    Console.WriteLine("Incrementing Data Selector");
                    this._dataSelector++;

                }},

                // <: Move data selector left(infinite in both directions)
                {'<', () => {
                     Console.WriteLine("Decrementing Data Selector");
                    this._dataSelector--;
                }},

                // +: Increment memory cell by 1. 255+1=0
                {'+', () => {
                    Console.WriteLine("Executing +");
                    if (this._memory.ContainsKey(this._dataSelector)){
                        if (this._memory[this._dataSelector] == 255){
                            this._memory[this._dataSelector] = 0;
                        } else {
                          this._memory[this._dataSelector]++;
                        }
                    } else {
                        this._memory.Add(_dataSelector, 1);
                    }
                }},

                // *: Add ascii value of memory cell to the output tape.
                {'*', () => {
                    Console.WriteLine("Executing *");
                    this._tape.Add((char)this._memory[this._dataSelector]);
                }},
            };

            }
            public void ProcessCommand(char command) => this.commands[command]();

            public int GetCurrentMemoryValue() => this._memory[this._dataSelector];

            public string GetTape() => String.Join("", this._tape);

            public override string ToString()
            {
                return $"pointer: {this._dataSelector}, memory size: {this._memory.Count()}";
            }
        }

        public class Ticker
        {
            public static string Interpret(string tape)
            {
                var processor = new Interpreter();
                tape.ToList().ForEach(command =>
                {
                    processor.ProcessCommand(command);
                });
                System.Console.WriteLine(processor);
                System.Console.WriteLine(processor.GetCurrentMemoryValue());
                return processor.GetTape();
            }
        }

        static void Main(string[] args)
        {
            var helloWorld = "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++**>+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>++++++++++++++++++++++++++++++++*>+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*<<*>>>++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*<<<<*>>>>>++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*>+++++++++++++++++++++++++++++++++*";

            Console.WriteLine(Ticker.Interpret(helloWorld));
        }
    }
}
