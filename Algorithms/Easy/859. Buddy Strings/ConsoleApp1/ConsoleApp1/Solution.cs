using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool BuddyStrings(string a, string b)
        {
            if (a == null || b == null)
                return false;

            if (a.Length != b.Length)
                return false;

            if (a.Equals(b) && HasDuplicates(a))
                return true;

            int numberOfDiffs = 2;
            char[] diffsA = new char[numberOfDiffs];
            char[] diffsB = new char[numberOfDiffs];
            int diffCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    if (diffCounter + 1 > numberOfDiffs)
                        return false;

                    diffsA[diffCounter] = a[i];
                    diffsB[diffCounter] = b[i];
                    diffCounter++;
                }
            }

            if (diffCounter != numberOfDiffs)
                return false;

            if (diffsA[0] == diffsB[1] && diffsA[1] == diffsB[0])
                return true;
            else
                return false;
        }

        private bool HasDuplicates(string str)
        {
            var uniqueLetters = new HashSet<char>(); 
            for (int i = 0; i < str.Length; i++)
            {
                if (uniqueLetters.Contains(str[i]))
                    return true;
                uniqueLetters.Add(str[i]);
            }
            return false;
        }
    }
}
