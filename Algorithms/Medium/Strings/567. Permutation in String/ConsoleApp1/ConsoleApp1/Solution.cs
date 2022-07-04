using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int[] target = new int[26];
            int[] window = new int[26];

            foreach (char c in s1)
            {
                target[c - 'a']++;
            }


            int i = 0, j = 0;
            while (j < s2.Length)
            {
                int cj = s2[j] - 'a';
                if (window[cj] + 1 <= target[cj])
                {
                    window[cj]++;
                    j++;

                    if (IsMatch(window, target)) return true;
                }
                else
                {
                    //while (i != j)
                    //{
                        int ci = s2[i] - 'a';
                        if (window[ci] > 0)
                        {
                            window[ci]--;
                        }
                        i++;
                    //}

                    //window[cj]++;
                    //j++;
                }
            }

            return false;
        }

        private bool IsMatch(int[] window, int[] target)
        {
            return Enumerable.SequenceEqual(window, target);
        }
    }
}
