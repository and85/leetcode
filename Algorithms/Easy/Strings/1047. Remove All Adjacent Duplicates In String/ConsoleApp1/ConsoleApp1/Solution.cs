using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string RemoveDuplicates(string S)
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
