using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4 };

            var solution = new Solution();
            solution.ProductExceptSelf(input);

            Console.ReadLine();
        }
    }
}
