using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int curr = 0, max = 0;
            for (int i =  0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    curr++;
                    if (curr > max)
                        max = curr;
                }
                else
                    curr = 0;
            }

            return max;
        }
    }
}
