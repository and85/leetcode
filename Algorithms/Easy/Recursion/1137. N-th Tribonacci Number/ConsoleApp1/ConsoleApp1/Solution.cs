using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        //public int Tribonacci(int n)
        //{
        //    if (n == 0)
        //        return 0;
        //    if (n == 1)
        //        return 1;
        //    if (n == 2)
        //        return 1;

        //    return Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
        //}
        public int Tribonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;

            int[] sums = new int[n + 1];
            sums[0] = 0;
            sums[1] = 1;
            sums[2] = 1;
            int res = 0;
            for (int i = 3; i <= n; i++)
            {
                sums[i] = sums[i - 3] + sums[i - 2] + sums[i - 1];
                res = sums[i];
            }

            return res;
        }
    }
}
