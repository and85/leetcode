using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        /*
        Input: s = "++++"
        Output: 
        [
          "--++",
          "+--+",
          "++--"
        ]
        */
        public IList<string> GeneratePossibleNextMoves(string s)
        {
            var result = new List<string>();
            if (s.Length <= 1 || s == "--")
                return result;
            else if (s == "++")
            {
                result.Add("--");
                return result;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i + 1])
                {
                    continue;
                }

                if (s[i] == '+')
                {
                    char[] array = s.ToCharArray();
                    array[i] = FlipChar(array[i]);
                    array[i + 1] = array[i];
                    result.Add(new string(array));
                }
            }

            return result;
        }

        private char FlipChar(char c)
        {
            return '-';
        }
    }
}
