public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {                        
        int a = cost[0], b = cost[1], c;
        
        for (int i = 2; i < cost.Length; i++)
        {
            c = cost[i] + Math.Min(a, b);
            a = b;
            b = c;
        }

        return Math.Min(a, b);
    }

    public int MinCostClimbingStairs_Array(int[] cost)
    {        
        
        int[] dp = new int[cost.Length];
        dp[0] = cost[0];
        dp[1] = cost[1];
        
        for (int i = 2; i < cost.Length; i++)
        {
            dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);            
        }

        return Math.Min(dp[dp.Length - 1], dp[dp.Length - 2]);
    }
}