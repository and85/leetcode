using System.Text;

public class Solution
{
    public int SecondsToRemoveOccurrences(string s)
    {
        var sb = new StringBuilder(s);
        int seconds = 0;
    
        while (sb.ToString().Contains("01"))
        {
            sb.Replace("01", "10");
            seconds++;
        }

        return seconds;
    }
}