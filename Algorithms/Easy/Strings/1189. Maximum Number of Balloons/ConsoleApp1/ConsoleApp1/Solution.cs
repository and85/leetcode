using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            var groups = text.ToCharArray()
                .Where(c => "balon".Contains(c))
                .GroupBy(c => c)
                .ToDictionary(c => c.Key, c => c.Key == 'l' || c.Key == 'o' ? c.Count() / 2 : c.Count());

            if (!groups.ContainsKey('b') || 
                !groups.ContainsKey('a') || 
                !groups.ContainsKey('l') || 
                !groups.ContainsKey('o') || 
                !groups.ContainsKey('n'))
                return 0;

            return groups.Min(g => g.Value);
        }
    }
}
