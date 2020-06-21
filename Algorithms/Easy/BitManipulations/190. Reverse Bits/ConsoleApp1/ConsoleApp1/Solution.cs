using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public uint everseBits(uint n)
        {
            int i = 0, j = 31;
            uint leftBit, rightBit;
            while (i < j)
            {
                leftBit = GetBit(n, i);
                rightBit = GetBit(n, j);
                n = ReplaceBit(n, j, leftBit);
                n = ReplaceBit(n, i, rightBit);

                i++;
                j--;
            }

            return n;
        }

        private uint ReplaceBit(uint n, int index, uint bit)
        {
            if (bit == 1)
                n = SetBit(n, index);
            else
                n = ClearBit(n, index);
            return n;
        }

        public uint GetBit(uint num, int bitIndex)
        {
            return (uint)(((num & (1 << bitIndex)) > 0) ? 1 : 0);
        }

        public uint SetBit(uint num, int bitIndex)
        {
            return num | (uint)(1 << bitIndex);
        }

        public uint ClearBit(uint num, int bitIndex)
        {
            uint mask = (uint)~(1 << bitIndex);
            return num & mask;
        }
    }
}
