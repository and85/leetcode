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
            if (ransomNote.Length > magazine.Length)
                return false;

            var magazineLetters = magazine.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
            var ransomeLetters = ransomNote.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            return ransomeLetters.All(r => magazineLetters.ContainsKey(r.Key) && r.Value <= magazineLetters[r.Key]);
        }
    }
}
