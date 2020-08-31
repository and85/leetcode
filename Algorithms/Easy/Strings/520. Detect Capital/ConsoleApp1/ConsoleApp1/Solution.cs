using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length == 1)
                return true;

            if (word.All(l => char.IsUpper(l)))
                return true;

            if (word.All(l => char.IsLower(l)))
                return true;

            

            string substring = word.Substring(1, word.Length - 1);
            if (char.IsUpper(word[0]) && substring.All(l => char.IsLower(l)))
                return true;

            return false;
        }
    }
}
