using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    if (Math.Abs(i - dict[nums[i]]) <= k)
                        return true;
                    dict[nums[i]] = i;

                    //if (dict.Count > k)
                    //{
                    //    dict.Remove(nums[i - k]);
                    //}
                }
            }
            return false;
        }
    }
}
