using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var alphabet = GetAlienAlphabet(order);
            for (int i = 1; i < words.Length; i++)
            {
                if (!WordsOrdered(words[i - 1], words[i], alphabet))
                    return false;
            }

            return true;
        }

        private Dictionary<char, int> GetAlienAlphabet(string order)
        {
            return order
                .Select((c, i) => (c, i))
                .ToDictionary(c => c.c, c => c.i); ;
        }

        private bool WordsOrdered(string word1, string word2, Dictionary<char, int> alphabet)
        {
            int l1 = word1.Length;
            int l2 = word2.Length;
            int minLength = Math.Min(l1, l2);

            for (int i = 0; i < minLength; i++)
            {
                if (alphabet[word1[i]] > alphabet[word2[i]])
                    return false;
                if (alphabet[word1[i]] < alphabet[word2[i]])
                    return true;
            }

            return l1 <= l2;
        }
    }
}
