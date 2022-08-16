public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int maxProfit = 0;
        int minSeen = int.MaxValue;

        foreach (var p in prices)
        {
            minSeen = Math.Min(minSeen, p);
            maxProfit = Math.Max(maxProfit, p - minSeen);
        }

        return maxProfit;
    }
}