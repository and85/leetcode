public class Solution
{
    private const int PrimeNumber = 101;

    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(haystack)) return -1;
        if (string.IsNullOrEmpty(needle)) return -1;
        if (haystack.Length < needle.Length) return -1;

        int needleHash = CalculateHash(needle);
        int haystackHash = CalculateHash(haystack.Substring(0, needle.Length));

        if (TryFindMatch(haystack, needle, haystackHash, needleHash, 0, out _))
        {
            return 0;
        }

        for (int i = 1; i < haystack.Length - needle.Length + 1; i++)
        {
            haystackHash = CalculateRollingHash(haystack, i, needle.Length, haystackHash);

            if (TryFindMatch(haystack, needle, haystackHash, needleHash, i, out int foundIndex))
            {
                return foundIndex;
            }
        }

        return -1;
    }

    private int CalculateRollingHash(string str, int index, int substringLength, int oldHash)
    {        
        int removedSymbol = str[index - 1];
        int addedSymbol = str[index + substringLength - 1];

        int hash = oldHash - removedSymbol;
        hash /= PrimeNumber;
        hash += (int)(addedSymbol * Math.Pow(PrimeNumber, substringLength - 1));        
        return hash;
    }
   

    // used formula a + b*p + c*p^2
    private int CalculateHash(string str)
    {
        int hash = 0;

        for (int i = 0; i < str.Length; i++)
        {            
            double symbol = str[i];
            hash += (int)(symbol * Math.Pow(PrimeNumber, i));            
        }

        return hash;
    }

    private bool TryFindMatch(
        string haystack, 
        string needle, 
        int haystackHash, 
        int needleHash, 
        int index, 
        out int foundIndex)
    {
        foundIndex = -1;
        if (needleHash == haystackHash)
        {
            string substring = haystack.Substring(index, needle.Length);
            if (substring.Equals(needle))
            {
                foundIndex = index;
                return true;
            }
        }

        return false;
    }
}