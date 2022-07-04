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
            if (n <= 2) return n;

            if (_memoization.ContainsKey(n)) return _memoization[n];

            int steps = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            _memoization.Add(n, steps);

            return steps;
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
