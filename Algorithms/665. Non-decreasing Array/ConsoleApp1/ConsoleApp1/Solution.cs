using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            for (int i = 0; i <nums.Length - 1; i++)
            {
                if (nums[i + 1] < nums[i])
                {
                    int left = nums[i]; 
                    int right = nums[i + 1];

                    nums[i] = right;
                    if (IsNonDecreasingArray(nums))
                        return true;

                    nums[i] = left;
                    nums[i + 1] = left;

                    return IsNonDecreasingArray(nums);
                }
            }

            return true;
        }

        private bool IsNonDecreasingArray(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] < nums[i])
                    return false;
            }

            return true;
        }
    }
}
