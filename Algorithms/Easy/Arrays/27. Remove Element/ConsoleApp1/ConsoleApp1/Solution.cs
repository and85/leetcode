using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int r = 0, w = 0;
            while (r < nums.Length)
            {
                if (nums[r] != val)
                {
                    nums[w] = nums[r];
                    w++;
                }

                r++;
            }

            return w;
            //return BruteForce(nums, val);
        }

        private static int BruteForce(int[] nums, int val)
        {
            int duplicatesCounter = 0;
            for (int i = 0; i < nums.Length - duplicatesCounter; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i + 1; j < nums.Length - duplicatesCounter; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    duplicatesCounter++;
                    i--;
                }
            }

            return nums.Length - duplicatesCounter;
        }
    }
}
