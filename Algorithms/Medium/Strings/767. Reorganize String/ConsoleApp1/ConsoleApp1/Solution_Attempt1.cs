using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Solution_Attempt1
    {
        public string ReorganizeString(string s)
        {
            var entrances = s.ToCharArray()
                .GroupBy(c => c)
                .ToDictionary(c => c.Key.ToString(), c => c.Count());

            int maxCount = entrances.Max(e => e.Value);
            if (IsPossible(entrances, maxCount, s.Length))
            {
                return ReorganizeString(entrances);
            }

            return string.Empty;    
        }

        private bool IsPossible(Dictionary<string, int> entrances, int maxCount, int length)
        {
            int restLength = length - maxCount;
            return maxCount - restLength <= 1;
        }

        private string ReorganizeString(Dictionary<string, int> entrances)
        {
            var resultSb = new StringBuilder();
            int maxCount = entrances.Max(e => e.Value);

            while (maxCount > 0)
            {
                var maxEntrance = entrances.First(e => e.Value == maxCount);
                string maxEntranceKey = maxEntrance.Key;

                entrances[maxEntranceKey]--;
                resultSb.Append(maxEntranceKey);

                string otherKey = entrances
                    .FirstOrDefault(e => e.Key != maxEntranceKey && e.Value > 0).Key;
                if (otherKey != null)
                {
                    resultSb.Append(otherKey);
                    entrances[otherKey]--;
                }

                maxCount = entrances.Max(e => e.Value);
            }

            return resultSb.ToString();
        }
    }
}
