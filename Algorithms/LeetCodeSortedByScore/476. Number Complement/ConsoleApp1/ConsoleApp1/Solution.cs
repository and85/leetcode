using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            int reversed = ~num;

            for (int i = 31; i >= 0; i--)
            {
                if (!GetBit(reversed, i))
                    break;
                reversed = ResetBit(reversed, i);
            }

            return reversed;
        }

        private bool GetBit(int num, int i)
        {
            return ((num & (1 << i)) != 0);
        }

        private int ResetBit(int num, int i)
        {
            int mask = ~(1 << i);
            return num & mask;
        }
    }
}
