using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };

            var solution = new Solution();
            double actual = solution.FindMedianSortedArrays(nums1, nums2);
            
            Console.ReadLine();
        }
    }
}
