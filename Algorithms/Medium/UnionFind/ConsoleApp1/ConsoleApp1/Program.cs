using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var edges = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            var edges2 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
            };

            var solution = new Solution();
            int res = solution.CountComponents(5, edges);
            int res2 = solution.CountComponents(5, edges2);

            Console.WriteLine(res);
            Console.WriteLine(res2);

            Console.ReadLine();
        }
    }
}
