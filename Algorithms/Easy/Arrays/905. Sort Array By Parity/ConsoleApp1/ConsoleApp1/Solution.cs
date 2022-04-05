using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int i = 0, j = nums.Length - 1;

            while (i < j)
            {
                if (nums[i] % 2 == 0)
                {
                    i++;
                }
                else
                {
                    Swap(nums, i, j);
                    j--;
                }
            }

            return nums;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }
    }
}
