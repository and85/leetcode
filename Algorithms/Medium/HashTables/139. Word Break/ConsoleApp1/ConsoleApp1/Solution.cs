using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var bits = new bool[s.Length];
            foreach (string word in wordDict)
            {
                var positions = GetWordPositions(s, word);
                foreach (var pos in positions)
                {
                    for (int i = pos.Item1; i <= pos.Item2; i++)
                    {
                        // already set
                        if (bits[i]) 
                            return false;

                        bits[i] = true;
                    }
                }
            }

            // all bits were set
            return bits.All(e => e);
        }

        private List<(int, int)> GetWordPositions(string s, string word)
        {
            var result = new List<(int, int)>();
            for (int i = 0; i < s.Length - word.Length + 1; i++)
            {
                if (s.Substring(i, word.Length).Equals(word))
                    result.Add((i, i + word.Length - 1));
            }

            return result;
        }
    }
}
