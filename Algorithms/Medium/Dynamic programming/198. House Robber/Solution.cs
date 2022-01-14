public class Solution 
{
    public int Rob(int[] nums) 
    {
        if (nums.Length == 1) 
            return nums[0];        

        int[] dp = new int[nums.Length + 1];       
        dp[0] = 0;        
        dp[1] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            dp[i + 1] = Math.Max(nums[i] + dp[i - 1], dp[i]); 
        }


        return dp[nums.Length];
    }
}