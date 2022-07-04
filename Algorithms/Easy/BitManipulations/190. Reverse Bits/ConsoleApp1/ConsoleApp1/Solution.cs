using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {                              
                uint rightBit = GetRightBit(n);

                result <<= 1;

                if (rightBit > 0)
                {
                    // set the most right bit
                    result |= 1;
                }                                
                
                n >>= 1;                
            }            

            return result;
        }

        public uint GetRightBit(uint x)
        {
            uint mask = 1;
            return x & mask;
        }


    }
}
