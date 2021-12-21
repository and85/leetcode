using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // sieve of eratosthenes implementation
    public class Solution
    {
        public int CountPrimes(int n)
        {
            int result = 0;
            var nums = new BitArray(n);
            nums.SetAll(true);


            for (int i = 2; i * i < n; i++)
            {
                if (nums.Get(i))
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        nums.Set(j, false);
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (nums.Get(i))
                    result++;
            }

            return result;
        }
    }
}
