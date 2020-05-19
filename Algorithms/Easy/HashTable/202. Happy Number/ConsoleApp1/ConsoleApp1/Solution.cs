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
            var existingSums = new HashSet<int>();

            while (true)
            {
                int sum = 0;
                foreach (int digit in GetDigits(n))
                {
                    sum +=  (int)Math.Pow(digit, 2);
                }
                
                if (sum == 1)
                    return true;

                if (existingSums.Contains(sum))
                    return false;
                else
                {
                    n = sum;
                    existingSums.Add(sum);
                }
                
            }
        }

        private IEnumerable<int> GetDigits(int n)
        {
            do
            {
                yield return n % 10;
                n = n / 10;

            } while (n != 0);
        }
    }
}
