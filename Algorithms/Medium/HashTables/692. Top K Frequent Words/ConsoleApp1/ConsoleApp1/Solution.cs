using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                    wordsCount[word]++;
                else
                    wordsCount.Add(word, 1);
            }

            return wordsCount
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .Take(k)
                    .Select(x => x.Key)
                    .ToList();
        }
    }
}
