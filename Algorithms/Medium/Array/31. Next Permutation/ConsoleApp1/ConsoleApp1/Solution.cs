using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            int i;
            for (i = nums.Length - 1; i >= 1; i--)
            {
                if (nums[i - 1] < nums[i])
                {                    
                    break;
                }
            }

            int decreasingPoint = i - 1;

            if (decreasingPoint >= 0)
            { 

                int minIndex = decreasingPoint, minValue = int.MaxValue;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] < minValue && nums[j] > nums[decreasingPoint])
                    {
                        minValue = nums[j];
                        minIndex = j;
                    }
                }
            
                Swap(nums, decreasingPoint, minIndex);
            }

            Array.Sort(nums, i, nums.Length - i);            
        }

        private void Swap(int[] nums, int i, int j)
        {
            int t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }
    }
}
