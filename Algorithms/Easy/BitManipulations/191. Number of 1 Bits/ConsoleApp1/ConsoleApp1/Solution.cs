using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            int weight = 0;
            for (int i = 0; i < sizeof(uint) * 8; i++)
            {
                weight += (int)(n & 1);
                n >>= 1;
            }

            return weight;
        }
    }
}
