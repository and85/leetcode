using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            //int[] nums = new int[] { 0, 1, 0, 3, 12 };
            //int[] nums = new int[] { 1, 2 };
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 0, 0, 6, 6, 7, 8, 9, 0 };
            int[] nums = new int[] { 0, 0, 0, 1 };
            s.MoveZeroes(nums);

            foreach (var n in nums)
                Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
