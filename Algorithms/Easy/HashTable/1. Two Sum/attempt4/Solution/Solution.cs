using System;

public class Solution {

    public int[] TwoSum(int[] nums, int target) 
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int search = target - nums[i];

            if (dict.ContainsKey(search))
            {
                return new int[] {dict[search], i};
            }

            dict.Add(nums[i], i);
        }

        return null;
    }

    public int[] TwoSum_Attempt1(int[] nums, int target) 
    {
        
        var dict = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], new List<int>() {i});
            }
            else
            {
                dict[nums[i]].Add(i);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int search = target - nums[i];

            if (dict.ContainsKey(search))
            {
                foreach(var index in dict[search])
                {
                    if (index != i)
                    {
                        return new int[] {i, index};
                    }
                }
            }
        }

        return null;
    }
}