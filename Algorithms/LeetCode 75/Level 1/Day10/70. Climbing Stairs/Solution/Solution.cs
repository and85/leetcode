public class Solution 
{
        private Dictionary<int, int> _memoization = new Dictionary<int, int>();

        public int ClimbStairs_Recursion(int n)
        {   
            if (n <= 2) return n;

            if (_memoization.ContainsKey(n)) return _memoization[n];

            int res = ClimbStairs_Recursion(n - 1) + ClimbStairs_Recursion(n - 2);
            _memoization.Add(n, res);

            return res;
        }

        public int ClimbStairs(int n)
        {   
            if (n <= 1) return n;

            int a = 1, b = 1, cur = 0;

            for (int i = 2; i <= n; i++)
            {
                cur = a + b;
                b = a;
                a = cur;
            }
            
            return cur;
        }                    
}