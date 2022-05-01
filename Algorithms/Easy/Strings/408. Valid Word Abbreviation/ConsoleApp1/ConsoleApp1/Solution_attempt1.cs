using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Solution_attempt1
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            string pattern = GetRegexPattern(abbr);
            var regex = new System.Text.RegularExpressions.Regex(pattern);
            return regex.IsMatch(word);
        }

        private string GetRegexPattern(string abbr)
        {
            string numbers = "[0-9]+";
            var regex = new System.Text.RegularExpressions.Regex(numbers);
            var matches = regex.Matches(abbr);
            var evaluator = new System.Text.RegularExpressions.MatchEvaluator(EntryNumber);

            return "^" + regex.Replace(abbr, evaluator) + "$";
        }

        private string EntryNumber(System.Text.RegularExpressions.Match match)
        {
            // expected number of letters
            string matchStr = match.ToString();

            if (matchStr.StartsWith("0"))
                return "[^a-z]";

            return "[a-z]{" + matchStr + "}";
        }
    }
}
