using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumWays(int n, int k)
        {
            if (n == 0)
                return 0;

            if (n == 2)
                return k * k;

            if (n == 1)
                return k;

            if (n == 2)
                return k * k;

            return (NumWays(n - 1, k) + NumWays(n - 2, k)) * (k - 1);
        }
    }
}
