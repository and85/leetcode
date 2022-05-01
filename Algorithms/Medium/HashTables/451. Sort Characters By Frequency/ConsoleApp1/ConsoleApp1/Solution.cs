using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string FrequencySort(string s)
        {
            var counts = s.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Value);


            var sb = new StringBuilder();

            foreach (var freq in counts)
            {
                sb.Append(new string(freq.Key, freq.Value));
            }

            return sb.ToString();
        }
    }
}
