using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        //public int LengthOfLastWord(string s)
        //{
        //    if (string.IsNullOrWhiteSpace(s))
        //        return 0;

        //    bool wordStarted = false;
        //    int fisrtSymbol = 0;

        //    for (int i = s.Length - 1; i >= 0; i--)
        //    {
        //        if (s[i] == ' ' && wordStarted)
        //            return fisrtSymbol - i;

        //        if (s[i] != ' ' && !wordStarted)
        //        {
        //            wordStarted = true;
        //            fisrtSymbol = i;
        //        }

        //    }

        //    if (wordStarted)
        //        return fisrtSymbol + 1;

        //    return 0;
        //}
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int counter = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && counter != 0)
                    return counter;

                if (s[i] != ' ')
                {
                    counter++;
                }

            }

            return counter;
        }
    }
}
