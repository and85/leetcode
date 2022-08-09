using System.Text;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int sp = 0, tp = 0;

        while (sp < s.Length)
        {
            if (tp == t.Length) return false;

            if (s[sp] == t[tp])
            {
                sp++;
            }
            tp++;
        }

        return true;

        //return StringBuilderApproach(s, t);


        //return ConstantSpace(s, t);
    }

    private static bool StringBuilderApproach(string s, string t)
    {
        var sb = new StringBuilder();

        int j = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (j == s.Length) break;

            if (t[i] != s[j]) continue;

            sb.Append(t[i]);
            j++;
        }

        return sb.Equals(s);
    }

    // doesn't work
    private static bool ConstantSpace(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return true;
        if (string.IsNullOrEmpty(t)) return false;

        if (s.Length == t.Length) return s.Equals(t);

        bool[] usedSymbols = new bool[26];

        for (int i = 0; i < s.Length; i++)
        {
            usedSymbols[s[i] - 'a'] = true;
        }

        int sr = 0;

        for (int tr = 0; tr < t.Length; tr++)
        {
            if (sr == s.Length) return true;

            if (!usedSymbols[t[tr] - 'a']) continue;

            if (t[tr] != s[sr]) return false;
            sr++;
        }

        return sr == s.Length;
    }
}