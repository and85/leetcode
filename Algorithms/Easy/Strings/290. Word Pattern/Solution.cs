public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');

        if (words.Length != pattern.Length) return false;

        var dict = new Dictionary<char, string>();
        var hashSet = new HashSet<string>();
        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, words[i]);
                if (hashSet.Contains(words[i])) return false;

                hashSet.Add(words[i]);
            }
            else
            {
                if (dict[c] != words[i]) return false;
            }
        }

        return true;
    }
}