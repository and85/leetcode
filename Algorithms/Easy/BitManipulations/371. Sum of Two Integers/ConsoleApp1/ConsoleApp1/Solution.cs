using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int GetSum(int a, int b)
        {
            return 0;
        }

        public int GetBit(int num, int bitIndex)
        {
            return ((num & (1 << bitIndex)) > 0) ? 1 : 0;
        }
    }
}
