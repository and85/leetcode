using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var sum1 = solution.MaxAbsoluteSum(new int[] { 1, -3, 2, 3, -4});
            var sum2 = solution.MaxAbsoluteSum(new int[] { 2, -5, 1, -4, 3, -2 });
            var sum3 = solution.MaxAbsoluteSum(new int[] { -7, -1, 0, -2, 1, 3, 8, -2, -6, -1, -10, -6, -6, 8, -4, -9, -4, 1, 4, -9 });

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            Console.ReadLine();
        }
    }
}
