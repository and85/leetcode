using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            var grouped = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                string sortedStr = GetSortedStr(str);
                if (grouped.ContainsKey(sortedStr))
                {
                    grouped[sortedStr].Add(str);
                }
                else
                {
                    grouped.Add(sortedStr, new List<string>() { str });
                }
            }

            foreach (var g in grouped)
            {
                result.Add(g.Value);
            }
            
            return result;
        }

        private string GetSortedStr(string str)
        {
            var array = str.ToCharArray();
            Array.Sort(array);

            return new string(array);
        }
    }
}
