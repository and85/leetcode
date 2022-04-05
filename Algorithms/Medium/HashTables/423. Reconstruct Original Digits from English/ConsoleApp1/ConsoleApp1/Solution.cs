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
            var numbers = new Dictionary<string, string>()
            {
                { "zero", "0" },
                { "one", "1" },
                { "two", "2" },
                { "three", "3" },
                {  "four", "4" },
                {  "five", "5" },
                { "six", "6"},
                { "seven", "7"},
                { "eight", "8"},
                { "nine", "9" }
            };


            var sb = new StringBuilder();
            var counts = s.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            foreach (var num in numbers)
            {
                while (CanTake(counts, num.Key))
                {
                    sb.Append(num.Value);
                }
            }

            return sb.ToString() ;
        }

        private bool CanTake(Dictionary<char, int> counts, string number)
        {
            char[] numArr = number.ToArray();
            if (numArr.All(c => counts.ContainsKey(c) && counts[c] > 0))
            {
                foreach (var c in numArr)
                {
                    counts[c]--;
                }
                
                return true;
            }

            return false;
        }
    }
}
