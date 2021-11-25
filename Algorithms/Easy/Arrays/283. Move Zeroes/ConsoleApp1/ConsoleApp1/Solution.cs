using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            

            //Approach1(nums);            
            // my second solution coded after reading solutions
            for (int i = 0, lastSeenNonZero = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i != lastSeenNonZero)
                    {
                        Swap(nums, i, lastSeenNonZero);
                    }
                    lastSeenNonZero++;
                }
            }

        }

        private void Swap(int[] nums, int i, int j)
        {
            int t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }

        private static void Approach1(int[] nums)
        {
            /*
            c 2
                        
            w
               r

            0, 1, 0, 3, 12
            1, 0, 0, 3, 12
            
            1, 2, 3, 4, 5, 0, 0
            */

            // my original solution
            int i, r = 0, w = 0, z = 0;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[r] == 0)
                {
                    r++;
                    z++;
                    continue;
                }

                if (w != r)
                    nums[w] = nums[r];

                r++;
                w++;
            }

            for (int j = nums.Length - z; j < nums.Length; j++)
                nums[j] = 0;
        }
    }
}
