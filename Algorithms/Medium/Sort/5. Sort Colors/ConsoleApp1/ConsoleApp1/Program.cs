using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            solution.SortColors(nums);

            Console.ReadLine();
        }
    }
}
