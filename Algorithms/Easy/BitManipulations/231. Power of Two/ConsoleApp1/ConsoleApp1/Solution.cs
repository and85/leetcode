using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {

            if (n <= 0) return false;
            
            int count = 0;
            for (int i = 0; i < 32; i++)
            {                
                count += GetFirstBit(n);

                if (count > 1) return false;

                n >>= 1;
            }

            
            return count == 1;
        }

        private int GetFirstBit(int x)
        {
            int mask = 1;
            return x & mask;
        }

        public bool IsPowerOfTwo_Attempt1(int n)
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
