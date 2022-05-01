using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int GetMaximumGenerated(int n)
        {
            if (n == 0) return 0;
            
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            int max = 1;

            int i = 0;
            while (2 * i + 1 <= n)
            {
                
                dp[2 * i] = dp[i];
                dp[2 * i + 1] = dp[i] + dp[i + 1];
                max = Math.Max(max, dp[2 * i]);
                max = Math.Max(max, dp[2 * i + 1]);
                i++;                
            } 


            return max;
        }
    }
}
