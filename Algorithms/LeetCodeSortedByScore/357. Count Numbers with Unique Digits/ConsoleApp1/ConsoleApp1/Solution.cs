using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0)
                return 1;

            if (n == 1)
                return 10;

            // why this formula doesn't work?
            int p = Factorial(10) / Factorial(10 - n);
            int c = Factorial(10) / (Factorial(10 - n) * Factorial(n));

            return p;
        }

        public int Factorial(int number)
        {
            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
