using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (sb.Length >= 1 && s[i] == sb[sb.Length - 1])
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }

        public string RemoveDuplicates_Attempt1(string S)
        {
            if (S.Length <= 1)
                return S;

            BitArray removed = new BitArray(S.Length);
            int i = 0, j = 1;

            while (j < S.Length)
            {
                if (S[i] != S[j])  
                {
                    i = j;
                    j++;
                }
                else
                {
                    removed[i] = true;
                    removed[j] = true;
                    if (i != 0)
                        i--;
                    else
                        i = j;
                    
                    j++; 
                }
            }

            var sb = new StringBuilder();
            for (int r = 0; r < removed.Length; r++)
            {
                if (!removed[r])
                    sb.Append(S[r]);
            }

            return sb.ToString();
        }
    }

}
