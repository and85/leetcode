using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            // find left position
            int left = 0;
            int right = nums.Length;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] >= target)
                    right = mid;
                else
                    left = mid + 1;
            }
            if (left >= nums.Length || nums[left] != target) return new int[] { -1, -1 };

            int left_pos = left;

            //find right position
            left = left_pos;
            right = nums.Length;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > target)
                    right = mid;
                else
                    left = mid + 1;
            }
            int right_pos = left - 1;
            return new int[] { left_pos, right_pos };

        }

        
    }
}
