namespace PalindromicSubstrings;
public class Solution
{

    public int CountSubstrings(string s)
    {                
        return 0;
    }

    public int CountSubstrings_BruteForce(string s)
    {
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        for (int j = i; j < s.Length; j++)
        {
            res += IsPalindrom_BruteForce(s, i, j);
        }
        
        return res;
    }

    private int IsPalindrom_BruteForce(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return 0;
            }

            i++;
            j--;
        }

        return 1;
    }
}
