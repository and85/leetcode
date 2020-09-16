using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int[] nums = new int[] { 121, 12 };

            Console.WriteLine(solution.LargestNumber(nums));
            Console.ReadLine();
        }
    }
}
