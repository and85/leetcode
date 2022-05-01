using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string OriginalDigits(string s)
        {
            var list = new List<int>();
            var counts = s.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
            
            ProcessNumber(list, counts, 'z', 0, "zero");
            ProcessNumber(list, counts, 'w', 2, "two");
            ProcessNumber(list, counts, 'x', 6, "six");
            ProcessNumber(list, counts, 'x', 6, "six");
            ProcessNumber(list, counts, 'g', 8, "eight");
            ProcessNumber(list, counts, 'u', 4, "four");
            ProcessNumber(list, counts, 't', 3, "three");
            ProcessNumber(list, counts, 'f', 5, "five");
            ProcessNumber(list, counts, 's', 7, "seven");
            ProcessNumber(list, counts, 'i', 9, "nine");
            ProcessNumber(list, counts, 'o', 1, "one");

            return string.Join("", list.OrderBy(n => n));
        }

        private void ProcessNumber(List<int> list, Dictionary<char, int> counts, char key, int keyInt, string num)
        {
            if (!counts.ContainsKey(key) || counts[key] == 0) return;

            int count = GetCount(key, counts);

            foreach (var c in num)
            {
                ReduceCount(c, count, counts);                
            }

            AddOccurences(keyInt, count, list);
        }

        private void AddOccurences(int v, int count, List<int> list)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(v);
            }
        }

        private void ReduceCount(char v, int count, Dictionary<char, int> counts)
        {
            counts[v] -= count;
        }

        private int GetCount(char v, Dictionary<char, int> counts)
        {
            return counts[v];
        }
    }
}
