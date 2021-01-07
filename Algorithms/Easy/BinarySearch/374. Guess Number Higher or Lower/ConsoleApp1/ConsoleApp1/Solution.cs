using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /** 
     * Forward declaration of guess API.
     * @param  num   your guess
     * @return 	     -1 if num is lower than the guess number
     *			      1 if num is higher than the guess number
     *               otherwise return 0
     * int guess(int num);
     */

    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            long left = 1, right = n;
            int median;
            int guessRes;
            do
            {
                median = (int)((left + right) / 2);
                guessRes = guess(median);
                
                if (guessRes < 0)
                {
                    right = median - 1;
                }
                else if (guessRes > 0)
                {
                    left = median + 1;
                }
            }
            while (guessRes != 0);

            return median;
        }
    }
}
