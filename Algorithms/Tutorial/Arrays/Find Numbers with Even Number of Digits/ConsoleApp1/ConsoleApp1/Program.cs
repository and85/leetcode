using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12, 345, 2, 6, 7896 };
            var solution = new Solution();
            int res = solution.FindNumbers(nums);

            Console.ReadLine();

        }
    }
}
