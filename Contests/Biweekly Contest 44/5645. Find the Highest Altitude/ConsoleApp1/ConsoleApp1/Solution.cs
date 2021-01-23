using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            int cur = 0, max = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                cur += gain[i];
                max = Math.Max(cur, max);
            }

            return max;
        }
    }
}
