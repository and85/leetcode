using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            // only one bit should be set and it least 2 bit
            byte setBitCounter = 0;
            for (int i = 0; i < 32; i++)
            {
                if (IsBitSet(num, i))
                {
                    setBitCounter++;
                    if (i < 2 || setBitCounter > 1)
                        return false;
                }
            }

            return true;
        }

        public bool IsBitSet(int num, int bitIndex)
        {
            return ((num & (1 << bitIndex)) > 0);
        }
    }
}
