public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {        
        var map = new Dictionary<char, char>();
        var usedT = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
            {
                if (usedT.Contains(t[i])) return false;

                usedT.Add(t[i]);
                map.Add(s[i], t[i]);
            }
            else
            {
                if (t[i] != map[s[i]]) return false;
            }            
        }

        return true;
    }
}