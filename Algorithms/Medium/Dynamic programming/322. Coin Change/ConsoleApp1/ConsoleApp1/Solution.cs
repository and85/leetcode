using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
                return 0;

            var dp = new int[amount + 1];
            // fill by amount + 1, but not by int.Max to avoid integer overflow
            Array.Fill(dp, amount + 1);
            dp[0] = 0;

            for (int j = 1; j <= amount; j++)
            {
                for (int i = 0; i < coins.Length; i++)
                {
                    if (coins[i] <= j)
                    {
                        dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}
