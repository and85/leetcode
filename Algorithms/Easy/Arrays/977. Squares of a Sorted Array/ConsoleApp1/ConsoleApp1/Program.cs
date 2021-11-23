using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            int[] nums = new int[] { -4, -1, 0, 3, 10 };
            var res = s.SortedSquares(nums);

            foreach (var n in res)
            {
                Console.WriteLine(n);
            }
        }
    }
}
