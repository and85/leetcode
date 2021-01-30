using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[][] times = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 2, 3, 1 },
                new int[] { 3, 4, 1 },
            };
            //int[][] times = new int[][]
            //{
            //    new int[] { 1, 2, 1 }
            //};
            int maxCost = solution.NetworkDelayTime(times, 4, 2);
            
            Console.WriteLine(maxCost);
            Console.ReadLine();
        }
    }
}
