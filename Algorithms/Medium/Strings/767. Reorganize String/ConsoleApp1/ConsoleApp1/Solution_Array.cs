using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_Array
    {
        private const int AlphabetLength = 26;
        private const int ASCICodeA = 97;

        public string ReorganizeString(string s)
        {
            int[] counts = new int[AlphabetLength];
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - ASCICodeA;
                counts[index]++;
            }
            var stringBuilder = new StringBuilder();
            char prev = '0';
            for (int i = 0; i < s.Length; i++)
            {
                if (TryGetNextFeasebleSymbol(counts, prev, out var nexSymbol))
                {
                    prev = nexSymbol;
                    stringBuilder.Append(nexSymbol);
                }
                else
                {
                    return string.Empty;
                }
            }
            return stringBuilder.ToString();
        }

        private bool TryGetNextFeasebleSymbol(int[] counts, char prevSymbol, out char nexSymbol)
        {
            nexSymbol = '0';            
            int max = 0, maxIndex = -1;
            bool maxFound = false;

            for (int i = 0; i < AlphabetLength; i++)
            {                
                if (i == prevSymbol - ASCICodeA) continue;
                if (counts[i] > max)
                {
                    max = counts[i];
                    maxIndex = i;
                    maxFound = true;
                }
            }

            if (!maxFound) return false;
            
            counts[maxIndex]--;
            nexSymbol = Convert.ToChar(maxIndex + ASCICodeA);

            

            return true;
        }

    }
}
