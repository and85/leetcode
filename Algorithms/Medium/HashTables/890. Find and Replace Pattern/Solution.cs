public class Solution 
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern) 
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            if (word.Length != pattern.Length) continue;

            if (PatternMatch(word, pattern))
            {
                result.Add(word);
            }
        }

        return result;
    }

    private bool PatternMatch(string word, string pattern)
    {
        var dict = new Dictionary<char, char>();
        var mapped = new HashSet<char>();

        for (int i = 0; i < word.Length; i++)
        {
            char p = pattern[i];
            char w = word[i];

            if (dict.ContainsKey(p))
            {
                if (w != dict[p]) return false;
            }
            else
            {
                if (mapped.Contains(w)) return false;

                mapped.Add(w);
                dict.Add(p, w);
            }
        }

        return true;
    }
}