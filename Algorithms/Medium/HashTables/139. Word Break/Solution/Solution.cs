using System.Text;

public class Solution
{    
    public bool WordBreak(string s, IList<string> wordDict)
    {
        //return WordBreakRecur(s, new HashSet<string>(wordDict), 0);
        //return WordBreakQueue(s, new HashSet<string>(wordDict));
        return WordBreakDp(s, new HashSet<string>(wordDict));
    }

    private Dictionary<int, bool> _memo = new Dictionary<int, bool>();

    private bool WordBreakRecur(string s, HashSet<string> wordDict, int start)
    {
        if (s.Length == start)
        {
            return true;
        }

        if (_memo.ContainsKey(start))
            return _memo[start];

        for (int end = start + 1; end <= s.Length; end++)
        {
            if (wordDict.Contains(s.Substring(start, end - start)) && WordBreakRecur(s, wordDict, end))
            {
                _memo[start] = true;
                return true;
            }
        }

        _memo[start] = false;
        return false;
    }

    private bool WordBreakQueue(string s, HashSet<string> wordDict)
    {
        var queue = new Queue<int>();
        queue.Enqueue(0);

        bool[] visited = new bool[s.Length];        

        while (queue.Count > 0)
        {
            int start = queue.Dequeue();

            if (visited[start]) continue;

            for (int end = start + 1; end <= s.Length; end++)
            {
                if (wordDict.Contains(s.Substring(start, end - start)))
                {
                    queue.Enqueue(end);

                    if (end == s.Length) return true;
                }
            }

            visited[start] = true;
        }

        return false;
    }

    private bool WordBreakDp(string s, HashSet<string> wordDict)
    {
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;

        for (int len = 1; len <= s.Length; len++)
        for (int start = 0; start < len ; start++)
        {
            if (dp[start] && wordDict.Contains(s.Substring(start, len - start)))
            {
                    dp[len] = true;
                    break;
            }
        }

        return dp[s.Length];
    }
}