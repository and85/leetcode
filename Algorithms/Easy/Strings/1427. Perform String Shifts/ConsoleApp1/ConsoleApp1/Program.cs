using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.StringShift("a", new int[][] 
            { 
                new int[] {1, 1 },
                new int[] {1, 1 },
                new int[] {0, 2 },
                new int[] {1, 3 },
                new int[] {0, 0 }
            });
        }
    }
}
