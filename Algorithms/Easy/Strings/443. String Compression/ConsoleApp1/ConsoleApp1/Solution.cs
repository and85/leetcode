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
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i - 1] == chars[i])
                {
                    if (!currSet)
                    {
                        curr = i;
                        //counter = 1;
                    }
                    currSet = true;
                    counter++;
                }
                else
                {
                    currSet = false;
                    chars[curr] = Convert.ToChar(counter.ToString());
                    counter = 1;
                }
            }

            if (counter > 1)
                chars[curr] = Convert.ToChar(counter.ToString());

            return curr + 1;
        }
    }
}
