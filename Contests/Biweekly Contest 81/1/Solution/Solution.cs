public class Solution 
{
    public int CountAsterisks(string s) 
    {
        int result = 0;
        var parts = s.Split('|');


        for (int i = 0; i < parts.Length; i += 2)
        {
            result += parts[i].ToCharArray().Where(c => c.Equals('*')).Count();
        }

        return result;
    }
}