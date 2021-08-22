using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FixedPoint(int[] arr)
        {
            int l = 0, r = arr.Length - 1, m, res = -1;

            while (l <= r)
            {
                m = l + (r - l) / 2;

                if (arr[m] == m)
                {
                    res = m;
                    r = m - 1;
                }
                if (arr[m] < m) l = m + 1;
                if (arr[m] > m) r = m - 1;
            }

            return res;
        }
    }
}
