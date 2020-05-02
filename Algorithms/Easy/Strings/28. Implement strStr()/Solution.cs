// https://leetcode.com/problems/implement-strstr/submissions/
public class Solution {
    public int StrStr(string haystack, string needle) {
           if (string.IsNullOrWhiteSpace(needle))
            return 0;
        if (string.IsNullOrWhiteSpace(haystack))
            return -1;
        
        int startWith = -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (needle.StartsWith(haystack[i]))
            {
                startWith = i;
                bool isNotNeedle = false;
                for (int j=1; j < needle.Length; j++)
                {
                    if (i+j < haystack.Length)
                    {
                        if(needle[j] != haystack[i+j])
                            isNotNeedle = true;
                    }
                    else return -1;
                }
                
                if (!isNotNeedle)
                    return startWith;
            }
        }
        
        return -1;
    }
}