using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            // only one bit should be set for the power of 2
            int setBitCounter = 0;
            while (n != 0)
            {
                setBitCounter += n & 1;
                if (setBitCounter > 1) return false;
               
                n >>= 1;
            }
            
            return setBitCounter == 1;
        }
    }
}
