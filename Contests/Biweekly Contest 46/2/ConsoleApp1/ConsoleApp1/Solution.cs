using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CanChoose(int[][] groups, int[] nums)
        {
            int shift = 0;
            foreach (int[] group in groups)
            {
                bool matchFound = false;
                for (int i = shift; i <= nums.Length - group.Length; i++)
                {
                    matchFound = MatchFound(group, i, nums);
                    if (matchFound)
                    {
                        shift = i + group.Length;
                        break;
                    }
                }

                if (!matchFound)
                    return false;
            }

            return true;
        }

        private bool MatchFound(int[] group, int shift, int[] nums)
        {
            for (int i = 0; i < group.Length; i++)
            {
                if (nums[shift + i] != group[i])
                    return false;
            }

            return true;
        }
    }
}
