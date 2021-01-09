using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private string[] _morseCodes = new string[26]
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", 
            "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        public int UniqueMorseRepresentations(string[] words)
        {
            var uniqueTransf = new HashSet<string>();
            Array.ForEach(words, w => uniqueTransf.Add(GetTransformation(w)));

            return uniqueTransf.Count;
        }

        private string GetTransformation(string word)
        {
            var sb = new StringBuilder();
            foreach (char c in word)
            {
                sb.Append(_morseCodes[c - 97]);
            }

            return sb.ToString();
        }
    }
}
