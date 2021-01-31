using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RecursiveBruteForceSolution
    {
        // O(n ^ 2)
        public string RemoveDuplicates(string S)
        {
            if (string.IsNullOrWhiteSpace(S) || S.Length == 1)
                return S;

            var sb = new StringBuilder(S);
            RemoveDuplicates(sb);

            return sb.ToString();
        }

        private void RemoveDuplicates(StringBuilder sb)
        {
            bool duplicateFound = false;
            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i - 1] == sb[i])
                {
                    sb.Remove(i - 1, 2);
                    duplicateFound = true;
                    break;
                }
            }

            if (duplicateFound)
                RemoveDuplicates(sb);
        }
    }
}
