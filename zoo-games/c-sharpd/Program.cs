using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharpd
{

    public class Dinglemouse
    {

        private static Dictionary<string, IList<String>> Eats = new Dictionary<string, IList<String>>{
            {"antelope",new List<string> {"grass"}},
            {"big-fish",new List<string> {"little-fish"}},
            {"bug",new List<string> {"leaves"}},
            {"bear",new List<string> {"big-fish","bug","chicken","cow","leaves","sheep"}},
            {"chicken",new List<string> {"bug"}},
            {"cow",new List<string> {"grass"}},
            {"fox",new List<string> {"chicken","sheep"}},
            {"giraffe",new List<string> {"leaves"}},
            {"lion",new List<string> {"antelope","cow"}},
            {"panda",new List<string> {"leaves"}},
            {"sheep",new List<string> {"grass"}},
        };


        public static IList<string> WhoEatsWho(string zoo)
        {
            System.Console.WriteLine("zoo: " + zoo);
            // Your code here
            var rv = new List<string>();
            rv.Add(zoo);
            // parse zoo 
            var feeding = zoo.Split(',').ToList();
            var i = 0;
            while (i < feeding.Count && feeding.Count != 1)
            {
                System.Console.WriteLine( $"Checking " + feeding[i]);
                var left = (i - 1 >= 0) ? feeding[i - 1] : String.Empty;
                var right = (i + 1 < feeding.Count) ? feeding[i + 1] : String.Empty;
                var thisAnimal = feeding[i];
                System.Console.WriteLine($"L:{left} C:{thisAnimal} R:{right}");
                if (Eats.ContainsKey(thisAnimal))
                {
                    if (Eats[thisAnimal].Any(a => a == left))
                    {
                        System.Console.WriteLine($"found it to the left, {thisAnimal} eats {left}");
                        rv.Add($"{thisAnimal} eats {left}");
                        feeding.RemoveAt(i -1);
                        i = -1;
                        
                    }
                    else if (Eats[thisAnimal].Any(a => a == right))
                    {
                        System.Console.WriteLine($"found it to the right, {thisAnimal} eats {right}");
                        rv.Add($"{thisAnimal} eats {right}");
                        feeding.RemoveAt(i +1);
                        i = -1;
                    }
                }
                i++;
                
            }
            rv.Add(String.Join(",",feeding));
            return rv;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var test = Dinglemouse.WhoEatsWho("chicken,fox,leaves,bug,grass,sheep");
            System.Console.WriteLine("_--------------------_");
            foreach (var item in test)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
