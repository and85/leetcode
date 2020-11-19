using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var bannedHashSet = new HashSet<string>(banned);
            var separators = new char[] { '!', '?', '\'', ',', ';', '.', ' ' };

            var allwords = paragraph.ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => !bannedHashSet.Contains(w))
                .GroupBy(w => w)
                .ToDictionary(w => w.Key, w => w.Count());

            int maxValue = 0;
            string mostFrequentWord = "";

            foreach(var word in allwords)
            {
                if (word.Value > maxValue)
                {
                    maxValue = word.Value;
                    mostFrequentWord = word.Key;
                }
            }

            return mostFrequentWord;
        }
    }
}
