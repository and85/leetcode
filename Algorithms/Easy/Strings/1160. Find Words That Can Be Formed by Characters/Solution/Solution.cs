public class Solution {
    public int CountCharacters(string[] words, string chars) {
        var letters = chars.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

        int res = 0;
        foreach (var word in words)
        {
            var wordDict = word.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            bool flag = false;
            foreach (var w in wordDict)
            {
                if (!letters.ContainsKey(w.Key))
                {
                    flag = true;
                    break;
                }
                if (letters[w.Key] < w.Value)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                res += word.Length;
            }
        }

        return res;
    }
}