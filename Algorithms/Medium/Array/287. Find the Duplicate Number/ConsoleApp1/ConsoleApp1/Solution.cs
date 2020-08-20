using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            int slow = 0, fast = 0;

            while (true)
            {
                slow++;

                if (fast >= nums.Length)
                    fast = fast - nums.Length;
                if (slow == nums.Length)
                    slow = 0;

                if (nums[fast] == nums[slow] && fast != slow)
                    return nums[slow];
                
                fast = fast + 2;
            }
        }
    }
}
