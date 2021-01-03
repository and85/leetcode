using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int full = numBottles, 
                empty = 0, 
                drunk, 
                total = 0;

            while (full > 0)
            {
                total += full;
                drunk = (full + empty) / numExchange;
                empty = (full + empty) % numExchange;
                full = drunk;
            }

            return total;
        }
    }
}
