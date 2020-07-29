using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int zeroCounter = 0, zeroStart = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCounter++;
                    if (zeroStart == -1) zeroStart = i;
                }

                if ( i + 1 != nums.Length && nums[i + 1] != 0)
                {
                    ShiftZeros(nums, zeroStart, zeroCounter);
                    zeroStart = -1;
                    zeroCounter = 0;
                }
            }
        }

        private void ShiftZeros(int[] nums, int zeroStart, int zeroCounter)
        {
            if (zeroCounter == 0 || zeroStart == -1)
                return;

            for (int i = zeroStart; i < zeroStart + zeroCounter; i++)
            {
                if (i + zeroCounter >= nums.Length)
                    break;

                if (nums[i + zeroCounter] == 0)
                    break;

                nums[i] = nums[i + zeroCounter];
                nums[i + zeroCounter] = 0;
            }
        }
    }
}
