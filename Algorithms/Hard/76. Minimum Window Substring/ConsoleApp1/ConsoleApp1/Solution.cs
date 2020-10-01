using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> tEntries = t.ToCharArray()
                .GroupBy(c => c)
                .ToDictionary(c => c.Key, c => c.Count());

            int firstPointer = 0, secondPointer = 0;
            int prevFirstPointer = -1, prevSecondPointer = -1;
            string candidate = string.Empty, shortestCandidate = s;

            while (firstPointer < s.Length && 
                IsPointerMove(firstPointer, secondPointer, prevFirstPointer, prevSecondPointer))
            {
                prevFirstPointer = firstPointer;
                prevSecondPointer = secondPointer;

                candidate = s.Substring(firstPointer, secondPointer - firstPointer);

                // move first pointer till candidadate has all characters from t
                // move second pointer till we candidate doesn't have all characters from t

                // in the new candidate we should check not all entries, but only those that were
                // removed when moving the window, otherwise it will be too many comparations!!! 
                if (ContainsAllCharacters(candidate, tEntries))
                {
                    if (candidate.Length < shortestCandidate.Length)
                        shortestCandidate = candidate;

                    // remove from dictionary here

                    firstPointer++;
                }
                else
                {
                    // add to dictionary here

                    secondPointer++;
                    // we can't move out of s string
                    if (secondPointer > s.Length)
                        secondPointer = s.Length;
                }
            }

            if (ContainsAllCharacters(shortestCandidate, tEntries))
                return shortestCandidate;

            return string.Empty;
        }

        private bool IsPointerMove(int firstPointer, int secondPointer, 
            int prevFirstPointer, int prevSecondPointer)
        {
            return !(firstPointer == prevFirstPointer && secondPointer == prevSecondPointer);
        }

        private bool ContainsAllCharacters(string candidate, Dictionary<char, int> tEntries)
        {
            Dictionary<char, int> candidateEntries = candidate.ToCharArray()
                .GroupBy(c => c)
                .ToDictionary(c => c.Key, c => c.Count());

            return AllInEntriesDictionary(candidateEntries, tEntries);
        }

        private bool AllInEntriesDictionary(Dictionary<char, int> candidate, Dictionary<char, int> entries)
        {
            foreach (var entry in entries)
            {
                if (!candidate.ContainsKey(entry.Key) || candidate[entry.Key] < entry.Value)
                    return false;
            }

            return true;
        }
    }
}
