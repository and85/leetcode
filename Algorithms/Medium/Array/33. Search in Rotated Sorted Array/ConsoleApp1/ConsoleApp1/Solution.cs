using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            return BinarySearch(nums, target);
            //return BruteForce(nums, target);
        }

        private static int BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
            }

            return -1;
        }

        private static int BinarySearch(int[] nums, int target)
        {
            return -1;
        }
    }
}
