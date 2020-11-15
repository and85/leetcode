using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
                return 0;

            coins = coins.Distinct().ToArray();
            Array.Sort(coins);
            coins = coins.Reverse().ToArray();

            int coinsCounter = 0;
            int result = 0;
            while (coinsCounter < coins.Length && amount > 0)
            {
                // what is the minimal possible result if we take this coin?

                // what is the minimal possible result if we don't take this coin?
            }

            return (amount == 0) ? result : -1;
        }
    }
}
