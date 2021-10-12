using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<string> CommonChars(string[] words)
        {
            var firstWord = GetOccurrences(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                var nextWord = GetOccurrences(words[i]);

                foreach (var c in firstWord)
                {
                    if (nextWord.ContainsKey(c.Key))
                    {
                        firstWord[c.Key] = Math.Min(firstWord[c.Key], nextWord[c.Key]);
                    }
                    else
                    {
                        firstWord.Remove(c.Key);
                    }
                }
            }

            var result = new List<string>();

            foreach (var c in firstWord)
            {
                for (int i = 0; i < c.Value; i++)
                    result.Add(c.Key);
            }

            return result;
        }

        private Dictionary<string, int> GetOccurrences(string word)
        {
            return word.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key.ToString(), c => c.Count());
        }
    }
}
