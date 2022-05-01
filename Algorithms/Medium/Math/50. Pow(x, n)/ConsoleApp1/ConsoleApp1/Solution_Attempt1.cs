using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution_Attempt1
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;

            if (n == 1)
                return x;

            double halfRes = 1;
            if (n > 0)
                halfRes = MyPow(x, n / 2);
            else
                halfRes = 1 / MyPow(x, -n / 2);

            double res = halfRes * halfRes * CalculateRemainer(x, n);
            return !double.IsInfinity(res) ? res : 0;
        }

        private static double CalculateRemainer(double x, int n)
        {
            return ((n % 2 == 0) ? 1 : (n > 0 ? x : 1 / x));
        }
    }
}
