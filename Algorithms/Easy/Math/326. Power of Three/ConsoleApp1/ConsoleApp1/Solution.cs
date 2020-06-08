using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            if (n == 1) return true;

            while (n > 1)
            {
                if (n % 3 != 0)
                    return false;
                n = n / 3;
            }

            return true;
        }
    }
}
