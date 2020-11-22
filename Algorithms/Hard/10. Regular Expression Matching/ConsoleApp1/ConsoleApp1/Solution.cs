using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // wrong approach? solution uses different approaches, try again in a few weeks :)
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            int sInd = 0, pInd = 0;

            while (sInd < s.Length && pInd < p.Length)
            {
                int curP = pInd;
                if (pInd + 1 < p.Length && p[pInd + 1] == '*')
                {
                    while (sInd < s.Length && (s[sInd] == p[pInd] || p[pInd] == '.'))
                        sInd++;

                    while (pInd < p.Length && (p[pInd] == p[curP] || p[pInd] == '*'))
                        pInd++;

                    //pInd += 2;
                    continue;
                }

                if (p[pInd] == '.')
                {
                    sInd++;
                    pInd++;
                    continue;
                }

                if (s[sInd] == p[pInd])
                {
                    sInd++;
                    pInd++;
                    continue;
                }
            }

            return sInd == s.Length && pInd == p.Length;
        }
    }
}
