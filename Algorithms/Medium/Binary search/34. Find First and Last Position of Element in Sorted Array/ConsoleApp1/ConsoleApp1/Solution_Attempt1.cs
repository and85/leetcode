using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution_Attempt1
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return new int[] { -1, -1};

            int left = 0, right = nums.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }

            // Post-processing:
            // End Condition: left + 1 == right
            if (nums[left] == target)
            {
                return GetMatchEnd(nums, left);
            }

            if (nums[right] == target)
            {
                return GetMatchEnd(nums, right);
            }

            return new int[]{ -1, -1};
        }

        private int[] GetMatchEnd(int[] nums, int start)
        {
            int end = start;
            for (int i = start + 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[start])
                    end = i;
            }

            return new int[] { start, end };
        }
    }
}
