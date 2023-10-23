using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char, int>();
            foreach (char m in magazine)
            {
                if (!dict.ContainsKey(m))
                {
                    dict.Add(m, 1);
                }
                else
                {
                    dict[m]++;
                }
            }

            foreach (char r in ransomNote)
            {
                if (!dict.ContainsKey(r)) return false;
                dict[r]--;

                if (dict[r] < 0) return false;
            }

            return true;
        }
    }
}
