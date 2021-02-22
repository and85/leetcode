using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.MaxProduct(new int[] { 2, 3, -2, 4 });
            solution.MaxProduct(new int[] { -2, 0, -1 });
            solution.MaxProduct(new int[] { -2, 3, -4 });
            solution.MaxProduct(new int[] { -1, -2, -9, -6 });

            Console.ReadLine();
        }
    }
}
