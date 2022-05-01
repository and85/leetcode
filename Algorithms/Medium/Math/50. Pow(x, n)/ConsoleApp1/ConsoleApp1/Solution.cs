using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;

            long nn = n;

            if (n < 0)
            {
                x = 1 / x;
                nn = -nn;
            }

            double result = 1;
            double half = x;
            for (long i = nn; i > 0; i /= 2)
            {
                if (i % 2 == 1)
                    result = result * half;

                half = half * half;


            }

            return result;
        }

        public double MyPow_Recursive(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            if (n == -1) return 1 / x;

            double half = MyPow_Recursive(x, n / 2);
            return half * half * (GetRemainder(x, n));
        }

        private double GetRemainder(double x, int n)
        {
            return n % 2 != 0 ? (n > 0 ? x : 1 / x) : 1;
        }
    }
}
