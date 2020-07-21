using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12};

            var solution = new Solution();
            int res = solution.Search(nums, 9);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
