public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        var source = s.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

        foreach (var c in t)
        {
            if (source.ContainsKey(c))
            {
                source[c]--;                
            }
            else
            {
                return false;
            }
        }

        return source.All(c => c.Value == 0);
    }
}