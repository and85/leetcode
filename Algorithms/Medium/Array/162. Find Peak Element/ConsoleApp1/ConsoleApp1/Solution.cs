using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindPeakElement(int[] nums)
        {
            return FindPeakElementRecursive(nums, 0, nums.Length - 1);
        }

        private int FindPeakElementRecursive(int[] nums, int left, int right)
        {
            if (left == right)
                return left;

            int median = (right - left) / 2 + left;

            int leftNeighbour = (median - 1 >= 0) ? nums[median - 1] : int.MinValue;
            int rightNeighbour = (median + 1 < nums.Length) ? nums[median + 1] : int.MaxValue;

            if (nums[median] > leftNeighbour && nums[median] > rightNeighbour)
                return median;

            if (median != left)
                return FindPeakElementRecursive(nums, left, median);

            return FindPeakElementRecursive(nums, median + 1 , nums.Length - 1);
        }
    }
}
