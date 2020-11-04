using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, -1 };

            var solution = new Solution();
            solution.ProductExceptSelf(input);

            Console.ReadLine();
        }
    }
}
