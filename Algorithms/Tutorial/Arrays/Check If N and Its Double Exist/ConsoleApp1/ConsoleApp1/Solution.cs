using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            // binary search would give O(nlog(n)) but would be in place if
            // we sort an array and our sorting is in place, e.g. we use Quick sort

            // O(n)
            var hashTable = new HashSet<double>();
            foreach (int el in arr)
            {
                if (hashTable.Contains(el * 2) || hashTable.Contains(el / 2.0))
                    return true;

                if (!hashTable.Contains(el))
                    hashTable.Add(el);
            }

            return false;
        }
    }
}
