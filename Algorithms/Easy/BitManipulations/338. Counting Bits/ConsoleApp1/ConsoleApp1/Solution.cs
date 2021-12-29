using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _nextPowerOfTwo = 2;
        private int _prevPowerOfTwo = 0;

        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];            

            for (int i = 1; i <= n; i++)
            {                
                if (IsPowerTwo(i))
                {
                    result[i] = 1;                    
                    continue;
                }
                else
                {
                    result[i] = 1 + result[i - _prevPowerOfTwo];
                }
            }

            return result;
        }

        private bool IsPowerTwo(int i)
        {
            if (i == _nextPowerOfTwo)
            {
                _prevPowerOfTwo = _nextPowerOfTwo;
                _nextPowerOfTwo *= 2;
                return true;
            }

            return false;
        }

        public int[] CountBits_BitManipulations(int n)
        {
            int[] result = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                result[i] = CountOnes(i);                
            }

            return result;
        }

        private int CountOnes(int num)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                int bit = (num & 1) != 0 ? 1 : 0;
                num = num >> 1;
                result += bit;
            }

            return result;
        }

        

        

        

        
    }
}
