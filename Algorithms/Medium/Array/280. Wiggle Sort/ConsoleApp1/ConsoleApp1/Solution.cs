using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void WiggleSort(int[] nums)
        {
            if (nums.Length <= 1)
                return;

            // n log(n)
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i = i + 2)
            {
                if (i + 1 < nums.Length)
                {
                    Swap(nums, i);
                }
            }
        }

        private void Swap(int[] nums, int i)
        {
            int temp = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = temp;
        }
    }
}
