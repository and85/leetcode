using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {

        public int NumSquares(int n)
        {

            // https://leetcode.com/discuss/general-discussion/458695/dynamic-programming-patterns
            // Minimum (Maximum) Path to Reach a Target

            var squares = new List<int>();
            squares.Add(0);
            for (int i = 1; i <= n; i++)
            {
                if (IsPerfectSquare(i))
                    squares.Add(i);
            }
            var squaresArr = squares.ToArray();

            var dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 1; i < dp.Length; i++)
                dp[i] = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < squaresArr.Length; j++)
                {
                    if (squaresArr[j] <= i)
                        dp[i] = Math.Min(dp[i], dp[i - squaresArr[j]] + 1);
                }
            }

            return dp[n];
        }

        private bool IsPerfectSquare(double x)
        {
            double sr = Math.Sqrt(x);

            return ((sr - Math.Floor(sr)) == 0);
        }
    }
}
