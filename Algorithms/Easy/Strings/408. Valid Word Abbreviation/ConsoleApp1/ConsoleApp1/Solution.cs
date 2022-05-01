using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            int w = 0, a = 0;

            while (w < word.Length && a < abbr.Length)
            {
                if (word[w] == abbr[a])
                {
                    w++;
                    a++;
                    continue;
                }

                if (char.IsDigit(abbr[a]))
                {
                    // leading zero
                    if (abbr[a] == '0') return false;

                    int number = GetNumber(abbr, a);                    
                    w += number;
                    a += number.ToString().Length;

                    if (w >= word.Length) return false;
                }
                else
                {
                    return false;
                }

                w++;
                a++;
            }

            return w == word.Length && a == abbr.Length;
        }

        private int GetNumber(string abbr, int a)
        {
            StringBuilder sb = new StringBuilder();

            while (a < abbr.Length && char.IsDigit(abbr[a]))
            {
                sb.Append(abbr[a]);
                a++;
            }

            return int.Parse(sb.ToString());
        }
    }
}
