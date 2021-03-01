using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int[][] matrix = new int[3][]
            {
                new int[] { 0, 1, 2, 0 },
                new int[] { 3, 4, 5, 2 },
                new int[] { 1, 3, 1, 5 }
            };

            solution.SetZeroes(matrix);
            Console.ReadLine();
        }
    }
}
