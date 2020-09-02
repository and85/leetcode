using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = FindNextGreaterElement(nums, i);
            }

            return result;
        }

        private int FindNextGreaterElement(int[] nums, int i)
        {
            for (int j = i + 1; ; j++)
            {
                if (j == nums.Length)
                    j = 0;

                if (i == j)
                    break;

                if (nums[j] > nums[i])
                    return nums[j];
            }

            return -1;
        }
    }
}
