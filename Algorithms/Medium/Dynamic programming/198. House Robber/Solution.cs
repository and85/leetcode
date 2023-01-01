public class Solution 
{
    public int Rob(int[] nums)
    {
        // [1,2,3,1]
        int prev = 0;
        int cur = nums[0];
        int next = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            next = Math.Max(nums[i] + prev, cur);
            prev = cur;
            cur = next;
        }

        return cur;
    }

    private static int DynamicProgramming(int[] nums)
    {
        int[] dp = new int[nums.Length + 1];
        dp[0] = 0;
        dp[1] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i + 1] = Math.Max(nums[i] + dp[i - 1], dp[i]);
        }

        return dp[dp.Length - 1];
    }
}