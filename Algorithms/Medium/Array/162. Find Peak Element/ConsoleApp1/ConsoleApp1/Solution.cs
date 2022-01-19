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
            //return FindPeakElementRecursive(nums, 0, nums.Length - 1);
            int l = 0, r = nums.Length - 1;

            while (l < r)
            {
                int m = l + (r - l) / 2;

                if (nums[m] > nums[m + 1])
                    r = m;
                else
                    l = m + 1;
            }

            return l;
        }

        private int FindPeakElementRecursive(int[] nums, int left, int right)
        {
            if (left == right) return left;
            
            int median = left + (right - left) / 2;            
                        
            if (nums[median] > nums[median + 1])
                return FindPeakElementRecursive(nums, left, median);
            
            return FindPeakElementRecursive(nums, median + 1, right);                        
        }
    }
}
