using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            bool b1 = s.WordBreak("leetcode", new List<string>() { "leet", "code" });
            bool b2 = s.WordBreak("applepenapple", new List<string>() { "apple", "pen" });
            bool b3 = s.WordBreak("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" });

            Console.ReadLine();
        }
    }
}
