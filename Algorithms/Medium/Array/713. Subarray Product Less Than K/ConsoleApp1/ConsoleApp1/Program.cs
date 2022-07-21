using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.NumSubarrayProductLessThanK(new int[] { 10, 5, 2, 6 }, 100));
            Console.WriteLine(solution.NumSubarrayProductLessThanK(new int[] { 1, 2, 3 }, 0));
        }
    }
}
