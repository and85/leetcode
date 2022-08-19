public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {        
        
        int[] dp = new int[cost.Length];
        dp[0] = cost[0];
        dp[1] = cost[1];

        int min = Math.Min(dp[0], dp[1]);
        for (int i = 2; i < cost.Length; i++)
        {
            int c = cost[i];
            min = Math.Min(c + dp[i - 1], c + dp[i - 2]);
        }

        return min;
    }
}