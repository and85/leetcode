using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int zeroCounter = 0;
            int curElement;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    curElement = nums[i];
                    nums[i - zeroCounter] = curElement;
                }
                else
                {
                    zeroCounter++;
                }
            }

            // replace end elements by zeros
            for (int i = nums.Length - zeroCounter; i < nums.Length; i++)
                nums[i] = 0;
        }
    }
}
