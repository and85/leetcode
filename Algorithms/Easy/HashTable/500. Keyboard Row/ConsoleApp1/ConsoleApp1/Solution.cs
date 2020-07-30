using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string[] FindWords(string[] words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (IsOneLineWord(word.ToLower()))
                    result.Add(word);
            }

            return result.ToArray();

        }

        private bool IsOneLineWord(string word)
        {
            var row1 = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            var row2 = new HashSet<char>() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            var row3 = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            var rowIndexes = new List<int>();
            foreach (char ch in word)
            {
                int rowIndex = 0;
                if (row1.Contains(ch))
                    rowIndex = 1;
                else if (row2.Contains(ch))
                    rowIndex = 2;
                else if (row3.Contains(ch))
                    rowIndex = 3;
                if (rowIndexes.Count != 0)
                {
                    if (!rowIndexes.Contains(rowIndex))
                        return false;
                }
                else
                    rowIndexes.Add(rowIndex);
            }

            return true;
        }
    }
}
