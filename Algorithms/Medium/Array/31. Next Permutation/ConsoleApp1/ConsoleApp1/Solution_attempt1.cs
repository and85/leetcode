using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_attempt1
    {
        public void NextPermutation(int[] nums)
        {
            int decreasingIndex = FindDecreasingIndex(nums);
            if (decreasingIndex >= 0)
            {

                int nextGreaterIndex = NextGreaterIndex(nums, decreasingIndex);
                    
                Swap(nums, decreasingIndex, nextGreaterIndex);
                Reverse(nums, decreasingIndex + 1);
            }
            else
            {
                Array.Sort(nums);
            }
        }

        private int NextGreaterIndex(int[] nums, int decreasingIndex)
        {
            int min = int.MaxValue;
            int minIndex = -1;
            for (int i = decreasingIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[decreasingIndex])
                {
                    if (nums[i] <= min)
                    {
                        min = nums[i];
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }

        private int FindDecreasingIndex(int[] nums)
        {
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1])
                    return i - 1;
            }

            return -1;
        }

        private void Reverse(int[] nums, int start)
        {
            int i = start, j = nums.Length - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
