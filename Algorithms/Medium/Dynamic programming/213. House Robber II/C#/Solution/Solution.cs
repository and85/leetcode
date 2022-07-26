public class Solution 
{
    public int Rob(int[] nums) 
    {
        if (nums.Length == 1) return nums[0];
        return Math.Max(RobStartingFromHouse(0, nums.Length - 2, nums), RobStartingFromHouse(1, nums.Length - 1, nums));    
    }

    private int RobStartingFromHouse(int firstHouse, int lastHouse, int[] nums)
    {        
        int cur = 0, dp1 = nums[firstHouse], dp0 = 0;

        for (int i = firstHouse; i <= lastHouse; i++)
        {            
            int prev = cur;
            cur = Math.Max(dp0 + nums[i], dp1);

            dp1 = cur;
            dp0 = prev;
        }

        return cur;
    }
}
