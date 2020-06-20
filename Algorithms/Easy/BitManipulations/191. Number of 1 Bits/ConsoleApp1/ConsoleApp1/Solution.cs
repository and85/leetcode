using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            byte sum = 0;
            for (int i = 0; i < 32; i++)
                sum += IsBitSet(n, i);
            
            return sum;
        }

        private byte IsBitSet(uint num, int bitIndex)
        {
            bool isBitSet = (num & (1 << bitIndex)) > 0;
            return Convert.ToByte(isBitSet);
        }
    }
}
