using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            //int[] nums = new int[] { 1, 2 };
            s.MoveZeroes(nums);

            foreach (var n in nums)
                Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
