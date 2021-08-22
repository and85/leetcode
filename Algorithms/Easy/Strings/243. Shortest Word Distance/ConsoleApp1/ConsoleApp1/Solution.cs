using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            int p1 = -1, p2 = -1, min = int.MaxValue;
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1) p1 = i;
                if (wordsDict[i] == word2) p2 = i;

                if (p1 != -1 && p2 != -1)
                    min = Math.Min(Math.Abs(p1 - p2), min);
            }

            return min;
        }
    }
}
