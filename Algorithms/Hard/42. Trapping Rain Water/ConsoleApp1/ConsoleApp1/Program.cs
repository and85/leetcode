using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            var solution = new Solution();
            var sum = solution.Trap(input);

            Console.WriteLine($"Total: {sum}");

            Console.ReadLine();
        }
    }
}
