public class Solution
{
    public string GetHint(string secret, string guess)
    {
        /*
        build a mapFromSecret: (digit as a key, positions as a hashset)

        buid a dict of cows (digit as a key, numberOfCows as a value)

        iterate through guess: 
            IF guess digit is in a correct place then increase bulls, and remove a number from positions
            
            
            IF guess digit is in a wrong position, update cows dictionary (increase numberOfCows a dict)
                IF numberOfCows is less then a number of positions in mapFromSecret then increase cows

        */

        int bulls = 0, cows = 0;
        var cowsNumberDict = new Dictionary<char, int>();

        var secretMap = GetSecretMap(secret);

        for (int i = 0; i < guess.Length; i++)
        {
            char d = guess[i];

            if (secretMap.ContainsKey(d))
            {
                if (IsPositionCorrect(secretMap, i, d))
                {
                    secretMap[d].Remove(i);
                    bulls++;
                }
                else
                {
                    if (!cowsNumberDict.ContainsKey(d))
                    {
                        cowsNumberDict.Add(d, 0);
                    }
                    cowsNumberDict[d]++;                    
                }
            }
        }

        foreach (var cow in cowsNumberDict)
        {
            cows += Math.Min(secretMap[cow.Key].Count, cow.Value);
        }

        return $"{bulls}A{cows}B";
    }

    private bool IsPositionCorrect(Dictionary<char, HashSet<int>> secretMap, int i, char d)
    {
        return secretMap[d].Contains(i);
    }

    private static Dictionary<char, HashSet<int>> GetSecretMap(string secret)
    {
        var secretMap = new Dictionary<char, HashSet<int>>();
        for (int i = 0; i < secret.Length; i++)
        {
            char d = secret[i];
            if (!secretMap.ContainsKey(d))
            {
                secretMap.Add(d, new HashSet<int>());
            }
            secretMap[d].Add(i);
        }

        return secretMap;
    }
}