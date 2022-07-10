using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            var seenNumbers = new HashSet<int>();
            seenNumbers.Add(n);
            
            while (n != 1)
            {
                n = GetNextNumber(n);

                if (seenNumbers.Contains(n))
                {
                    return false;
                } 
                else
                {
                    seenNumbers.Add(n);
                }
                    
            }

            return true;
        }

        private int GetNextNumber(int n)
        {
            int res = 0;

            while (n > 0)
            {
                int digit = n % 10;
                res += digit * digit;
                n /= 10;
            }

            return res;
        }
    }
}
