using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private Dictionary<int, int> _memoization = new Dictionary<int, int>();

        public int ClimbStairs(int n)
        {                        
            /*
			if (n <= 2) return n;

            if (_memoization.ContainsKey(n)) return _memoization[n];

            int steps = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            _memoization.Add(n, steps);

            return steps;
			*/
			
			
			/* dynamic programming
			if (n <= 2) return n;

			dp[0] = 1;
			var dp = new int[n];
			dp[1] = 2;

			for (int i = 2; i < n; i++)
			{
				dp[i] = dp[i - 1] + dp[i - 2];
			}

			return dp[dp.Length - 1];
			*/
			int prev = 1, cur = 2, next;

			for (int i = 3; i <= n; i++)
			{
				next = cur + prev;
				prev = cur;
				cur = next;
			}

			return cur;			
        }

        public int ClimbStairs_Attempt1(int n)
        {
            if (_memoization.ContainsKey(n))
                return _memoization[n];

            if (n < 0)
                return 0;
            
            if (n == 0)
                return 1;

            int result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            _memoization.Add(n, result);

            return result;
        }
    }
}
