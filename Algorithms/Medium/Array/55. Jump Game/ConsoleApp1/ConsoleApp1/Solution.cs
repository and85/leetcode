using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            // 2, 3, 1, 1, 4
            // 0  1  2  3  4  --> index 4 - index 1 = 3 - can jump

            // 3, 2, 1, 0, 4 - 
            // 0  1  2  3  4 - index 4 - index 3 = 1 > 0 - can't jump
            int curIndex = 0;
            int lastIndex = nums.Length - 1;
            while (curIndex < lastIndex)
            {
                if (!CanJump(nums, curIndex))
                    return false;

                curIndex = GetNextPosition(nums, curIndex, lastIndex);
            }

            return true;
        }

        private int GetNextPosition(int[] nums, int curIndex, int lastIndex)
        {
            int maxIndex = curIndex;
            int step = nums[curIndex];
            int maxPosition = curIndex + step;

            for (int i = curIndex; i < curIndex + step; i++)
            {
                if (i == lastIndex)
                    return i;

                if (i + nums[i] > maxPosition)
                {
                    maxIndex = i;
                    maxPosition = i + nums[i];
                }
            }

            if (maxIndex == curIndex)
                maxIndex = curIndex + step;

            return maxIndex;
        }

        private bool CanJump(int[] nums, int curIndex)
        {
            return nums[curIndex] > 0;
        }
    }
}
