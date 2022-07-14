public class Solution {
    public int MinSubArrayLen(int target, int[] nums) 
    {
        int l = 0, r = 0, curSum = 0, min = int.MaxValue;

        while (r <= nums.Length)
        {
            if (curSum < target)
            {
                if (r < nums.Length)
                {
                    curSum += nums[r];
                }
                r++;
            }
            
            if (curSum >= target)
            {
                min = Math.Min(min, r - l);

                if (min == 1) return 1;

                curSum -= nums[l];
                l++;
            }
        }

        return min < int.MaxValue ? min : 0;
    }
}