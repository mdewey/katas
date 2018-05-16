using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
    public class TestCase
    {
        public bool answer { get; set; }
        public int[][] question { get; set; }
    }
    class Program
    {
        private static TestCase[] testCases = new TestCase[]
 {
      new  TestCase
      {
        answer = true,
        question = new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
          new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
        },
      },
      new TestCase
      {
        answer = false,
        question = new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
          new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
        },
      },
 };

        public static bool validateHasAll9Numbers(IEnumerable<int> collection)
        {
            var exists = Enumerable.Range(1, 9).ToDictionary(k => k, v => false);
            foreach (var item in collection)
            {
                if (exists.ContainsKey(item))
                {
                    exists[item] = !exists[item];
                }
            }
            return exists.All(a => a.Value);
        }

        public static IEnumerable<int> getGridFromLocation (int[][] puzzle, int x, int y ){
            var rv = new List<int>();
            for (int i = x-1; i <= x+1; i++)
            {
                for (int j = y-1; j <= y+1; j++)
                {
                    rv.Add(puzzle[i][j]);
                }
            }
            return rv;
        }

        public static bool ValidateSolution(int[][] board)
        {
            var isValid = true;

            var slotsToCheck = new List<IEnumerable<int>>();

            // add rows to be check checked

            for (int i = 0; i < board.Length; i++)
            {
                slotsToCheck.Add(board[i]);
                var col = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    col.Add(board[i][j]);
                }
                slotsToCheck.Add(col);
            }

            slotsToCheck.Add(getGridFromLocation(board, 1,1));
            slotsToCheck.Add(getGridFromLocation(board, 1,4));
            slotsToCheck.Add(getGridFromLocation(board, 1,7));
            slotsToCheck.Add(getGridFromLocation(board, 4,1));
            slotsToCheck.Add(getGridFromLocation(board, 4,4));
            slotsToCheck.Add(getGridFromLocation(board, 4,7));
            slotsToCheck.Add(getGridFromLocation(board, 7,1));
            slotsToCheck.Add(getGridFromLocation(board, 7,4));
            slotsToCheck.Add(getGridFromLocation(board, 7,7));

            System.Console.WriteLine( "Checking....");
            for (int i = 0; i < slotsToCheck.Count; i++)
            {
                System.Console.WriteLine(i);
                foreach (var item in slotsToCheck[i])
                {
                    System.Console.Write(item + ",");
                }
                System.Console.WriteLine("-----");
            }

             return slotsToCheck.All(a => validateHasAll9Numbers(a));
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("validateHasAll9Numbers");
            System.Console.WriteLine(validateHasAll9Numbers(new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 }) == true);
            System.Console.WriteLine(validateHasAll9Numbers(new int[] { 3, 3, 4, 6, 7, 8, 9, 1, 2 }) == false);
            System.Console.WriteLine(validateHasAll9Numbers(new int[] { 3, 4, 6, 7, 8, 9, 1, 2 }) == false);
            System.Console.WriteLine("validateSolution");
            Console.WriteLine(ValidateSolution(testCases[0].question) == testCases[0].answer);
            Console.WriteLine(ValidateSolution(testCases[1].question) == testCases[1].answer);
        }
    }
}
