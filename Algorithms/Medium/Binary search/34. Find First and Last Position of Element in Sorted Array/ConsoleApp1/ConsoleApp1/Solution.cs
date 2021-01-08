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
            if (nums == null || nums.Length == 0)
                return new int[] { -1, -1};

            int left = 0, right = nums.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    if (nums[mid + 1] == target )
                        return new int[] { mid, mid + 1};
                    if (nums[mid - 1] == target)
                        return new int[] { mid - 1, mid };
                }
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
            if (right + 1 < nums.Length && nums[right] == target && nums[right + 1] == target) 
                return new[] { right, right + 1 };
            if (left + 1 < nums.Length && nums[left] == target && nums[left + 1] == target)
                return new[] { left, left + 1 };

            if (left > 0 && nums[left - 1] == target && nums[left] == target)
                return new[] { left - 1, left };

            if (left > 0 && nums[left - 1] == target)
                return new[] { left - 1, left - 1 };

            if (nums[left] == target) return new[] { left, left };
            if (nums[right] == target) return new[] { right, right };

            return new int[]{ -1, -1};
        }
    }
}
