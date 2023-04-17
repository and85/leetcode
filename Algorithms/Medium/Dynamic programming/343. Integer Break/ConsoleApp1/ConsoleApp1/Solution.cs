using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int IntegerBreak(int n)
        {
            Extract(n);

            return 0;
        }

        private static void Extract(int n)
        {
            if (n == 0) return;

            for (int i = 1; i <= n; i++)
            {
                Extract(n - i);
            }
        }
    }
}
