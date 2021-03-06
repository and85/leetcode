﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    public class Solution
    {
        private bool _candidateFound = false;

        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> tEntries = t.ToCharArray()
                .GroupBy(c => c)
                .ToDictionary(c => c.Key, c => c.Count());

            int firstPointer = 0, secondPointer = 0;
            int prevFirstPointer = -1, prevSecondPointer = -1;
            string shortestCandidate = s;
            StringBuilder candidateSb = new StringBuilder();
            var candidateEntries = new Dictionary<char, int>();
            bool removedIrelevant = false;
            bool addedRemoved = false;
            char removedSymbol = '0';

            while (firstPointer < s.Length &&
                IsPointerMove(firstPointer, secondPointer, prevFirstPointer, prevSecondPointer))
            {
                prevFirstPointer = firstPointer;
                prevSecondPointer = secondPointer;

                // move first pointer till candidadate has all characters from t
                // move second pointer till we candidate doesn't have all characters from t
                // in the new candidate we should check not all entries, but only those that were
                // removed when moving the window, otherwise it will be too many comparations!!! 
                if (removedIrelevant || addedRemoved ||
                    (ContainsAllCharacters(candidateEntries, tEntries))
                    )
                {
                    if (candidateSb.Length < shortestCandidate.Length)
                        shortestCandidate = candidateSb.ToString();

                    // remove from dictionary here
                    char removedCh = s[firstPointer];
                    if (tEntries.ContainsKey(removedCh))
                    {
                        candidateEntries[removedCh]--;
                        if (candidateEntries[removedCh] == 0)
                            candidateEntries.Remove(removedCh);

                        removedIrelevant = false;
                        removedSymbol = removedCh;
                    }
                    else
                        removedIrelevant = true;

                    if (candidateSb.Length > 1)
                        candidateSb.Remove(0, 1);

                    addedRemoved = false;
                    firstPointer++;
                }
                else
                {
                    // add to dictionary here
                    if (secondPointer < s.Length)
                    {
                        char key = s[secondPointer];
                        if (tEntries.ContainsKey(key))
                        {
                            addedRemoved = key == removedSymbol;
                            if (candidateEntries.ContainsKey(key))
                                candidateEntries[key]++;
                            else
                                candidateEntries.Add(key, 1);
                        }

                        candidateSb.Append(key);
                    }


                    removedIrelevant = false;
                    secondPointer++;

                    // we can't move out of s string
                    if (secondPointer > s.Length)
                        secondPointer = s.Length;
                }
            }

            Dictionary<char, int> shortestCandidateEntries = shortestCandidate.ToCharArray()
                .Where(c => tEntries.ContainsKey(c))
                .GroupBy(c => c)
                .ToDictionary(c => c.Key, c => c.Count());

            if (ContainsAllCharacters(shortestCandidateEntries, tEntries))
                return shortestCandidate;

            return string.Empty;
        }

        private bool IsPointerMove(int firstPointer, int secondPointer,
            int prevFirstPointer, int prevSecondPointer)
        {
            return !(firstPointer == prevFirstPointer && secondPointer == prevSecondPointer);
        }

        private bool ContainsAllCharacters(Dictionary<char, int> candidate,
            Dictionary<char, int> tEntries)
        {
            if (candidate.Keys.Count != tEntries.Keys.Count)
                return false;

            return !tEntries.Any(e => candidate[e.Key] < e.Value);
        }
    }
}
