using System.Numerics;
using System.Text;

public class Solution {
    public string RemoveDigit(string number, char digit) 
    {
        BigInteger max = 0;
        var candidates = GetCandidates(number, digit).ToList<string>();

        foreach (var candidate in candidates)
        {
            BigInteger d = BigInteger.Parse(candidate);
            if (d > max)
            {
                max = d;
            }
        }

        return max.ToString("F0");
    }

    private IEnumerable<string> GetCandidates(string number, char digit)
    {        
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == digit)
            {
                string str1 = number.Substring(0, i);
                string str2 = number.Substring(i + 1, number.Length - i - 1);
                string str3 = str1 + str2;
                yield return str3;                
            }            
        }        
    }    
}