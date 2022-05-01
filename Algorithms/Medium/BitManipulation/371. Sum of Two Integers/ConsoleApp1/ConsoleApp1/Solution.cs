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
            int result;
            int carry = 0;
            for (int i = 31; i >=0; i--)
            {
                int d1 = GetBit(a, i);
                int d2 = GetBit(b, i);
            }

            return result;
        }

        private int GetBit(int a, int i)
        {
            return (1 << i) & a;
        }

        private int SetBit(int r, int i)
        {
            return (1 << i) & a;
        }
    }
}
