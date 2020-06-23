using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int CountPrimes(int n)
        {
            int result = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrimeNaive(i))
                    result++;
            }

            return result;
        }

        private bool IsPrimeNaive(int n)
        {
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
