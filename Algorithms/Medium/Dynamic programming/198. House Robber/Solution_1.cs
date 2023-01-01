public class Solution 
{
    public int Rob(int[] nums)
    {
        int next = 0, cur = nums[0], prev = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            next = Math.Max(nums[i] + prev, cur);
            prev = cur;
            cur = next;
        }

        return cur;
    }

    private static int Dp(int[] nums)
    {
        int[] dp = new int[nums.Length + 1];
        dp[0] = 0;
        dp[1] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            dp[i + 1] = Math.Max(nums[i] + dp[i - 1], dp[i]);
        }

        return dp[nums.Length];
    }

    public int Rob_Attempt1(int[] nums) 
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