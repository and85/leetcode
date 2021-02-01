using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int z = x ^ y;

            int bitsSet = 0;
            for (int i = 0; i < 32; i++)
            {
                bitsSet += z & 1;
                z = z >> 1;
            }

            return bitsSet;
        }
    }
}
