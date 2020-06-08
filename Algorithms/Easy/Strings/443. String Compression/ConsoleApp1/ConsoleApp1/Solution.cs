using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Compress(char[] chars)
        {
            if (chars.Length <= 1)
                return chars.Length;

            int curr = 1;
            bool currSet = false;
            int counter = 1;
            char charPrev = chars[0];
            for (int i = 1; i < chars.Length; i++)
            {
                if (charPrev == chars[i])
                {
                    if (!currSet)
                    {
                        curr = i;
                    }
                    currSet = true;
                    counter++;
                }
                else
                {
                    charPrev = SetCounter(chars, curr, counter); ;
                    currSet = false;
                    counter = 1;
                }
            }

            if (counter > 1)
            {
                SetCounter(chars, curr + 1, counter);
            }

            return curr + 1 + counter.ToString().Length;
        }

        private static char SetCounter(char[] chars, int curr, int counter)
        {
            char prev = chars[curr];
            string counterStr = counter.ToString();
            for (int i = 0; i < counterStr.Length; i++)
            {
                chars[curr + i] = counterStr[i];
            }

            return prev;
        }
    }
}
