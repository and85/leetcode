using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] SumZero(int n)
        {
            
            bool even = n % 2 == 0;

            int[] res = new int[n];
            
                for (int i = 0; i < n - (even ? 0 : 1); i += 2)
                {
                    res[i] = i + 1;
                    res[i + 1] = -res[i];
                }
            

            return res;
        }
    }
}
